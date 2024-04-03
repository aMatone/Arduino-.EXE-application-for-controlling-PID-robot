using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDControllerApplication
{
    internal class ConstantsProtocol
    {
        double kp;
        double ki;
        double kd;
        string toSend;
        public ConstantsProtocol(double kp, double ki, double kd)
        {
            this.kp = kp;
            this.ki = ki;
            this.kd = kd;

            this.toSend = GenerateProtocolString();
        }
        public ConstantsProtocol()
        {
            this.kp = 0;
            this.ki = 0;
            this.kd = 0;

            this.toSend = GenerateProtocolString();
        }

        public void UpdateKP(double kp)
        {
            this.kp = kp;
        }
        public void UpdateKI(double ki)
        {
            this.ki = ki;
        }
        public void UpdateKD(double kd)
        {
            this.kd = kd;
        }
        public string GenerateProtocolString()
        {
            return "kp=" + this.kp + ";ki=" + this.ki + ";kd=" + this.kd;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return toSend;
        }
    }
}
