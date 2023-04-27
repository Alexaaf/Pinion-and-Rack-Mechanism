#include <Stepper.h>

const float stepsPerRev = 32;
int motorSpeed = 700;
double nextPosition = 0.00;  

char c;
String appendSerialData;

double lastPos;
double currentPos;

bool flag = false; //this flag tells if the motor should move


Stepper steppermotor(stepsPerRev, 8, 10, 9, 11);

int i;
int sign;
long value;
float result;

int leftSensor = 2;
int rightSensor = 3;
int clockpin = 4;
int datapin = 5;

unsigned long tempmicros;

void setup()
{
  steppermotor.setSpeed(motorSpeed);
  pinMode(clockpin, INPUT);
  pinMode(datapin, INPUT);
  pinMode(leftSensor, INPUT);
  pinMode(rightSensor, INPUT);
  Serial.begin(9600);

}

void loop()
{
  while (digitalRead(clockpin) == LOW) {}
  //if clock is LOW wait until it turns to HIGH
  tempmicros = micros();

  while (digitalRead(clockpin) == HIGH) {}
  //wait for the end of the HIGH pulse
  if ((micros() - tempmicros) > 500) { //if the HIGH pulse was longer than 500 micros we are at the start of a new bit sequence
    lastPos = currentPos;
    currentPos = decode(); //decode the bit sequence and get current position
  }

  while (Serial.available() > 0) 
  {
    c = Serial.read(); //read data from serial port
    appendSerialData += c; //append to string
  }

  if (c == 'S') //if the last char is 'S', the motor speed is changed
  {
    int strlength = appendSerialData.length();
    appendSerialData[strlength - 1] = '\0'; //remove 'S'

    Serial.println("Set speed to: " + appendSerialData); //user feedback

    motorSpeed = appendSerialData.toInt(); 
    steppermotor.setSpeed(motorSpeed); //set new motor speed

    appendSerialData = ""; //reset the string
    c = 0;
  }

  if (c == 'P') // if the last char is 'P', the rack position is going to change
  {
    int strlength = appendSerialData.length();
    appendSerialData[strlength - 1] = '\0'; //remove 'P'

    Serial.println("Go to position: " + appendSerialData); //user feedback

    nextPosition = appendSerialData.toDouble(); // set desired position 

    flag = true; //the motor should move

    appendSerialData = ""; //reset string
    c = 0;
  }

  if (flag) { //if the position should change, call the function with the next position
    moveIt(nextPosition);
  }

  if (lastPos != currentPos) //display the current position only if it changed
  {
    Serial.print("Current position: ");
    Serial.println(currentPos);
  }
}


double decode() {

  sign = 1;
  value = 0;
  for (i = 0; i < 23; i++) {

    while (digitalRead(clockpin) == HIGH) { }
    while (digitalRead(clockpin) == LOW) {}

    if (digitalRead(datapin) == LOW) {
      if (i < 20) {
        value |= 1 << i;
      }

      if (i == 20) {
        sign = -1;
      }
    }
  }
  result = (value * sign) / 100.00;
  return result;
}

void moveIt(double nextPos)
{
  //read sensors
  int rightIRSensorValue = digitalRead(rightSensor);
  int leftIRSensorValue = digitalRead(leftSensor);

  //if the desired position is reached, the flag is set to false
  if ((currentPos >= nextPos && currentPos <= (nextPos + 0.10)) || ((currentPos <= nextPos) && (currentPos >= nextPos - 0.10)))
  {
    flag = false;
  }
  else {//the motor takes steps if the limits are not reached
        // the number of steps depends of how far it is from the desired position
        // i found this method really accurate, being able to reach the desired position +-0.10 without overshooting it.
    if ( currentPos > nextPos)
    {
      if(rightIRSensorValue != LOW) 
      {
        double diff = currentPos - nextPos;
        if ( diff > 10.00)
        {
          steppermotor.step(-100);
        }

        if ( diff < 10.00 && diff > 5.00)
        {
          steppermotor.step(-50);
        }

        if ( diff < 5.00 && diff > 2.00)
        {
          steppermotor.step(-10);
        }

        if ( diff < 2.00 )
        {
          steppermotor.step(-5);
        }
        if ( diff < 1.00 )
        {
          steppermotor.step(-2);
        }
      }
    } else {
      if (leftIRSensorValue != LOW)
      {
        double diff = nextPos - currentPos;
        if ( diff > 10.00)
        {
          steppermotor.step(100);
        }

        if ( diff < 10.00 && diff > 5.00)
        {
          steppermotor.step(50);
        }

        if ( diff < 5.00 && diff > 2.00)
        {
          steppermotor.step(10);
        }

        if ( diff < 2.00 )
        {
          steppermotor.step(5);
        }
        if ( diff < 1.00 )
        {
          steppermotor.step(2);
        }
      }

    }

  }
}
