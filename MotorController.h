#ifndef MotorController_h
#define MotorController_h

#include <Arduino.h>
#include <AFMotor.h>


#define VELOCIDADE_BASE 100

extern int referencia_linha;

void moverMotores(float saidaPID);

#endif
