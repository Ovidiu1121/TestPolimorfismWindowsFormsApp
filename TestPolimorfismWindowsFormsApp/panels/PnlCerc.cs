using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlCerc:PnlFigura
    {

        private PnlPunct b;
        private PnlLinie c;

        public PnlCerc()
        {

        }

        public PnlCerc(PnlPunct b, PnlLinie c)
        {
            this.b = b;
            this.c = c;
        }

        public PnlPunct B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public PnlLinie C
        {
            get { return this.c; }
            set { this.c = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE CERC--\nCercul este format din\n";

            PnlPunct p = b;
            PnlLinie l = c;

            text+="punct: ("+p.X+","+p.Y+")\n"+"linie: punct 1 ("+l.A.X+","+l.A.Y+"), punct 2: ("+l.B.X+","+l.B.Y+")\n";

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
            return new PnlCerc(this.b, this.c);
        }

    }
}
