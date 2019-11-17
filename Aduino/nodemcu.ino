/*
               
                       (0 0)
   +=============oOO====(_)================+
   |   By Linmb - www.linmb.com |
   |   Phone:15006008002     |
   |   Creation:2018.12.16                 |
   +==========================oOO==========+
                      |__|__|
                       || ||
                      ooO Ooo
                                          
*/
#include <RFID.h>
/* Include the standard Arduino SPI library */
#include <SPI.h>
/* 导入SPI库 */
#include <RFID.h>
/* 定义引脚. */
#define SDA_DIO 2
#define RESET_DIO 15
RFID RC522(SDA_DIO, RESET_DIO); 
const int biPin = 15;/* 定义蜂鸣器引脚. */
const int ledRedPin = 5; /* 定义LED引脚 */
const int ledGreenPin = 4;
const int ledBulePin = 0;
void setup()
{ 
  Serial.begin(9600);
  SPI.begin();  /* 开启SPI接口波特率为9600 */
  RC522.init();  /* 读卡器初始化 */
  initled();

}

void loop()
{
  digitalWrite(ledRedPin, HIGH);
  digitalWrite(ledBulePin, HIGH);
  /* 如果卡被读取 */
  if (RC522.isCard())
  {
    readerled(); //蜂鸣器响0.13s还有led
    RC522.readCardSerial();   //读取序列号
    digitalWrite(biPin, LOW);//关闭蜂鸣器
    digitalWrite(ledGreenPin, LOW);
    Serial.print("类  型: "); 
    Serial.print("S50");
    Serial.print("\n");
    Serial.print("卡  号: ");
    for(int i=0;i<5;i++)
    {
    Serial.print(RC522.serNum[i],DEC);  //十进制5次循环输出完整卡号
    //Serial.print(RC522.serNum[i],HEX); //十六进制输出卡号
    }
    Serial.print("\n");
 
  }
  digitalWrite(ledBulePin, HIGH);
  digitalWrite(ledGreenPin, HIGH);
  delay(100);
  digitalWrite(ledGreenPin, LOW);
  delay(50);
  digitalWrite(ledGreenPin, HIGH);
  delay(50);
  digitalWrite(ledGreenPin, LOW);
  delay(50);
  digitalWrite(ledGreenPin, HIGH);
  delay(70);
  digitalWrite(ledGreenPin, LOW);
  delay(70);
  digitalWrite(ledGreenPin, HIGH);
  delay(70);
  digitalWrite(ledGreenPin, LOW);
  delay(50);
  digitalWrite(ledGreenPin, HIGH);
  delay(70);
  digitalWrite(ledGreenPin, LOW);
  delay(70);
  digitalWrite(ledGreenPin, HIGH);
  delay(70);
  digitalWrite(ledGreenPin, LOW);
  delay(2000);
}
void initled(){
   pinMode(biPin, OUTPUT);  
  pinMode(ledRedPin, OUTPUT);
  pinMode(ledGreenPin, OUTPUT);
  pinMode(ledBulePin, OUTPUT);
  digitalWrite(biPin, HIGH);       //响
  digitalWrite(ledRedPin, HIGH);
       digitalWrite(ledGreenPin, HIGH);
         digitalWrite(ledBulePin, HIGH);
         delay(350); 
         digitalWrite(biPin, LOW);//关闭蜂鸣器
         digitalWrite(ledRedPin, LOW);
         digitalWrite(ledGreenPin, LOW);
         digitalWrite(ledBulePin, LOW);
  digitalWrite(ledRedPin, HIGH);
  delay(150); 
  digitalWrite(ledRedPin, LOW);
  digitalWrite(ledGreenPin, HIGH);
  delay(150); 
  digitalWrite(ledGreenPin, LOW);
  digitalWrite(ledBulePin, HIGH);
  delay(150); 
    digitalWrite(ledBulePin, LOW);
    delay(150); 
     digitalWrite(biPin, HIGH);
      digitalWrite(ledRedPin, HIGH);
      digitalWrite(ledGreenPin, HIGH);
      digitalWrite(ledBulePin, HIGH);
      delay(200); 
      digitalWrite(biPin, LOW);//关闭蜂鸣器
      digitalWrite(ledRedPin, LOW);
      digitalWrite(ledGreenPin, LOW);
      digitalWrite(ledBulePin, LOW);
      delay(100); 
      digitalWrite(biPin, HIGH);
      digitalWrite(ledRedPin, HIGH);
      digitalWrite(ledGreenPin, HIGH);
      digitalWrite(ledBulePin, HIGH);
      delay(200); 
      digitalWrite(biPin, LOW);//关闭蜂鸣器
      digitalWrite(ledRedPin, LOW);
      digitalWrite(ledGreenPin, LOW);
      digitalWrite(ledBulePin, LOW);
  }
  void readerled(){
     digitalWrite(ledBulePin, LOW);
     digitalWrite(ledRedPin, LOW);
     digitalWrite(biPin, HIGH);
     digitalWrite(ledGreenPin, HIGH);
     delay(100);
     digitalWrite(ledBulePin, HIGH);
      
    }
    
