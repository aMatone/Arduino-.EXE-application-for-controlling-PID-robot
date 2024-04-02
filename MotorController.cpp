#include "MotorController.h"

AF_DCMotor motorEsquerda(1);
AF_DCMotor motorDireita(2);


void moverMotores(float saidaPID) {
  
  int velocidadeMotorEsquerda = VELOCIDADE_BASE - saidaPID;
  int velocidadeMotorDireita = VELOCIDADE_BASE + saidaPID;

  velocidadeMotorEsquerda = constrain(velocidadeMotorEsquerda, -255, 255);
  velocidadeMotorDireita = constrain(velocidadeMotorDireita, -255, 255);

  motorEsquerda.setSpeed(abs(velocidadeMotorEsquerda));
  motorDireita.setSpeed(abs(velocidadeMotorDireita));

  if (velocidadeMotorEsquerda >= 0) {
    motorEsquerda.run(FORWARD);
  } else {
    motorEsquerda.run(BACKWARD);
  }
  
  if (velocidadeMotorDireita >= 0) {
    motorDireita.run(FORWARD);
  } else {
    motorDireita.run(BACKWARD);
  }
  
}
