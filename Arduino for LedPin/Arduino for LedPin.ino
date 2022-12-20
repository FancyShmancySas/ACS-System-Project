#include <SPI.h>
#include <MFRC522.h>
//MFRC522 - сканер

const int diod_delay = 1000;
int LedPinR = 3;
int LedPinG = 6;


#define RST_PIN         9          // Configurable, see typical pin layout above
#define SS_PIN          10         // Configurable, see typical pin layout above

MFRC522 mfrc522(SS_PIN, RST_PIN);  // Create MFRC522 instance глобальный экземпляр класса


void setup() {
    pinMode(LedPinG, OUTPUT);
    pinMode(LedPinR, OUTPUT);
    Serial.begin(9600);     // Initialize serial communications with the PC
    while (!Serial);        // Do nothing if no serial port is opened (added for Arduinos based on ATMEGA32U4)  крутимся в цикле пока не откроется порт
    SPI.begin();            // Init SPI bus
    mfrc522.PCD_Init();     // Init MFRC522
}

unsigned long getID(){
  if (!mfrc522.PICC_ReadCardSerial()) { //Since a PICC placed get Serial and continue
    return -1;
  }
  unsigned long hex_num;
  hex_num =  mfrc522.uid.uidByte[0] << 24; // записываем 4х байтовове число последовательно сдвигая то что записали ранее
  hex_num += mfrc522.uid.uidByte[1] << 16;
  hex_num += mfrc522.uid.uidByte[2] <<  8;
  hex_num += mfrc522.uid.uidByte[3];
  mfrc522.PICC_HaltA(); // Stop reading
  return hex_num;
}

void turn_on_green() {
  digitalWrite(LedPinG, HIGH); // Включение светодиода
  delay(diod_delay);                     // Задержка
  digitalWrite(LedPinG, LOW);  // Выключение светодиода
  delay(diod_delay); 
}

void turn_on_red() {
  digitalWrite(LedPinR, HIGH); // Включение светодиода
  delay(diod_delay);                     // Задержка
  digitalWrite(LedPinR, LOW);  // Выключение светодиода
  delay(diod_delay); 
}



void loop() 
{
    if(mfrc522.PICC_IsNewCardPresent()) { // если есть новая карточка 
      unsigned long uid = getID();
      if(uid != -1){
        Serial.println(uid);
      }
    } else {
      /* "ACTIVE", "BLOCKED" */
      if(Serial.available()) {
        String data = Serial.readString();
        data.trim();
        if(data == "ACTIVE") {
          turn_on_green(); // зажечь зеленый
        } else if(data == "BLOCKED") {
          turn_on_red(); // зажечь красный диод
        }
      }
    }
}