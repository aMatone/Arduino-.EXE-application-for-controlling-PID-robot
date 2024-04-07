#include <Arduino.h>
#include <SoftwareSerial.h>
#include "PIDController.h"
#include "MotorController.h"

// Define pinos
#define PINO_SENSOR_IR A0
#define PINO_RX_BT 2
#define PINO_TX_BT 3
#define BUTTON_PIN 7

int currentState = LOW;

void setup() {

  Serial.begin(9600);

  pinMode(BUTTON_PIN, INPUT_PULLUP);

  currentState = digitalRead(7);
  
  while(currentState == LOW){
    currentState = digitalRead(7);
  }
  referencia_linha = analogRead(PINO_SENSOR_IR);
}

void loop() {
  if (Serial.available()) {

    String stringPID = Serial.readStringUntil('\n');


    analisarStringPID(stringPID);
  }

  int valorSensor = analogRead(PINO_SENSOR_IR);
  float saidaPID = calcularPID(valorSensor);

  moverMotores(saidaPID);

}
