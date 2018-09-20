using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Bruch
    {
        public double zaehler { get; set; }
        public double nenner { get; set; }

        public Bruch(double z, double n)
        {
            zaehler = z;
            nenner = n;
        }

        public double proceed(){
            if (nenner == 0)
            {
                throw new DivideByZeroException("NICHT DURCH NULL TEILEN");
            }
            return zaehler / nenner;
        }

        public bool shorten()
        {
            double zs = zaehler, ns = nenner;
            for (int i = 2; i <= getNeutralDouble(zaehler) && i <= getNeutralDouble(nenner); i++)
            {
                if((zs % i)==0 && (ns%i)==0)
                {
                    zaehler /= i;
                    nenner /= i;
                    shorten();
                    return true;
                }
            }
            return false;
        }

        private double getNeutralDouble(double d) 
        {
            if (d < 0)
            {
                return d * -1;
            }
            else return d;
        }

    }
}
