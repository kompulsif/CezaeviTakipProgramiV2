#include <MFRC522.h>
#include <SPI.h>

#define RST_PIN         9
#define SS_PIN          10

MFRC522 mfrc522(SS_PIN, RST_PIN);   // MFRC522 instance oluştur

unsigned long lastReadTime = 0;     // Son okuma zamanı
unsigned long readInterval = 1000;  // Okuma aralığı (ms)

void setup() {
  Serial.begin(9600);        // Seri iletişimi başlat
  while (!Serial) {          // Serial bağlantısı sağlanana kadar beklet
    delay(1);
  }

  SPI.begin();               // SPI busunu başlat
  mfrc522.PCD_Init();        // MFRC522'yi başlat
  mfrc522.PCD_SetAntennaGain(mfrc522.RxGain_max);   // Anten kazancını maksimuma ayarla
}

void loop() {
  unsigned long currentTime = millis();

  if (currentTime - lastReadTime < readInterval) {   // Son okumadan yeterince zaman geçmediyse
    return;
  }

  if (!mfrc522.PICC_IsNewCardPresent() || !mfrc522.PICC_ReadCardSerial()) {
    return;
  }

  String cardID = "";
  for (byte i = 0; i < mfrc522.uid.size; i++) {
    cardID += String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "");
    cardID += String(mfrc522.uid.uidByte[i], HEX);
  }

  Serial.println(cardID);  // Kartın ID'sini seri monitöre yazdır

  lastReadTime = currentTime;     // Son okuma zamanını güncelle

  delay(1000);                     // Başka bir kart okumadan önce yarım saniye bekle
}
