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
                return 0;
            }
            else
            {
                return zaehler / nenner;
            }
        }

        public bool shorten()
        {
            double zs = zaehler, ns = nenner, tmp;
            for (int i = 2; i <= zaehler && i <= nenner; i++)
            {
                tmp = zs % i;
                if (tmp == 0)
                {
                    tmp = ns % i;
                    if (tmp == 0){
                        zaehler /= i;
                        nenner /= i;
                        shorten();
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
