#include "PIDController.h"

float erroAnterior = 0.0;
float integral = 0.0;
float kp = DEFAULT_KP;
float ki = DEFAULT_KI;
float kd = DEFAULT_KD;
int referencia_linha = 0;

void updatePID(float new_kp, float new_ki, float new_kd) {
  kp = new_kp;
  ki = new_ki;
  kd = new_kd;
}

float calcularPID(int valorSensor) {

  float erro = valorSensor - referencia_linha;

  integral += erro;

  float derivada = erro - erroAnterior;

  float saidaPID = kp * erro + ki * integral + kd * derivada;

  erroAnterior = erro;

  return saidaPID;
}

void analisarStringPID(String stringPID) {

  int indiceKp = stringPID.indexOf("kp=");
  int indiceKi = stringPID.indexOf("ki=");
  int indiceKd = stringPID.indexOf("kd=");

  if (indiceKp != -1 && indiceKi != -1 && indiceKd != -1) {

    int inicioKp = indiceKp + 3;
    int fimKp = indiceKi - 1;
    float novoKp = stringPID.substring(inicioKp, fimKp).toFloat();


    int inicioKi = indiceKi + 3;
    int fimKi = indiceKd - 1;
    float novoKi = stringPID.substring(inicioKi, fimKi).toFloat();


    int inicioKd = indiceKd + 3;
    float novoKd = stringPID.substring(inicioKd).toFloat();

    updatePID(novoKp, novoKi, novoKd);
  }
}
