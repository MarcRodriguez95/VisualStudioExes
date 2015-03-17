using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racional.Model
{
    class Racionales
    {
        private int a;
        private int b;

        public Racionales(int a, int b) {

            this.a = a;
            this.b = b;
        
        }
        public int getA() {
            return a;
        }

        public void setA(int a) {

            this.a = a; 
        }
        public int getB()
        {
            return b;
        }

        public void setB(int b)
        {
            if (b == 0) {
                throw new Exception("Forbidden values");
            }

            this.b = b;
        }

        public Racionales multiplicar(Racionales r) {

            int a = this.a * r.getA();
            int b = this.b * r.getB();

            return new Racionales (a, b);
        
        }

        public Racionales dividir(Racionales r) {

            int a = this.a * r.getB();
            int b = this.b * r.getA();

            return new Racionales(a, b);
        
        }

        public Racionales equivalente(Racionales r)
        {

            int a = this.a * r.getB();
            int b = this.b * r.getA();

            if (a == b ) {

                
            
            }

            return new Racionales(a, b);

        }




    }
}
