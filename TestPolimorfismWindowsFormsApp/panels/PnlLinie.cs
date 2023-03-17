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
        private PnlPunct b;

        public PnlLinie()
        {

        }

        public PnlLinie(PnlPunct a, PnlPunct b)
        {
            this.a=a;
            this.b=b;
        }

        public PnlPunct A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public PnlPunct B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE LINIE--\nLinia este formata din\n";

            PnlPunct p1 = a;
            PnlPunct p2 = b;

            text+="punct 1: ("+p1.X+","+p1.Y+")"+"\npunct 2: ("+p2.X+","+p2.Y+")\n";

            return text;

        }

        public override void translateX(int x)
        {
            base.translateX(x);
        }

        public override void translateY(int y)
        {
            base.translateY(y);
        }

        public override void translateYX(int x, int y)
        {
            base.translateYX(x, y);
        }

        public override PnlFigura duplicare()
        {

            return new PnlLinie(this.a, this.b);
        }

    }
}
