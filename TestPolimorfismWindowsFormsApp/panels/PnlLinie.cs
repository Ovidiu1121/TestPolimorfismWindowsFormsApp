using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlLinie:PnlFigura
    {

        private PnlPunct a;

        public PnlLinie(PnlPunct a)
        {
            this.a=a;
        }

        public PnlPunct A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE LINIE--\nLinia este formata din\n";

            PnlPunct p1 = a;

            text+="punct : ("+p1.X+","+p1.Y+")"+"\n";

            return text;

        }

        public override void translateX(int x)
        {
            this.a.translateX(x);
            this.Location=this.a.Location;
        }

        public override void translateY(int y)
        {
            this.a.translateY(y);
            this.Location=this.a.Location;
        }

        public override void translateYX(int x, int y)
        {
            this.a.translateYX(x, y);
            this.Location=this.a.Location;
        }


    }
}
