#ifndef PIDController_h
#define PIDController_h

#include <Arduino.h>

#define DEFAULT_KP 11.42239  // Ganho Proporcional padrão
#define DEFAULT_KI 18.5  // Ganho Integral padrão
#define DEFAULT_KD 0.98  // Ganho Derivativo padrão

extern float erroAnterior;
extern float integral;
extern float kp;
extern float ki;
extern float kd;
extern int referencia_linha;

void updatePID(float new_kp, float new_ki, float new_kd);
float calcularPID(int valorSensor);
void analisarStringPID(String stringPID);

#endif
  
