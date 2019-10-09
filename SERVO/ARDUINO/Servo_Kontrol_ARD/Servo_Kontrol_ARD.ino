#include <Servo.h>
int vbbuton;
Servo myservo;
byte randomservo;


void setup()
{
  myservo.attach(3);
  Serial.begin(9600);
  myservo.write(1);
}

void loop()
{
  randomservo = random();
  if (Serial.available())
  {
    delay(50);
    while (Serial.available() > 0)
    {
      vbbuton = Serial.read();
      if (vbbuton == '1')
      {
        myservo.write(1);
      }
      if (vbbuton == '2')
      {
        myservo.write(45);

      }
      if (vbbuton == '3')
      {
        myservo.write(90);
      }
      if (vbbuton == '4')
      {
        myservo.write(135);
      }
      if (vbbuton == '5')
      {
        myservo.write(180);
      }
      if (vbbuton == '6')
      {
        myservo.write(randomservo);
      }
    }
  }
}
