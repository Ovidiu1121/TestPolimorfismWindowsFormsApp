using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlEticheta:PnlDreptunghi
    {
        private string text;

        public PnlEticheta()
        {

        }

        public PnlEticheta(PnlLinie linie1, PnlLinie linie2, string textEticheta) : base(linie1, linie2)
        {
            this.text = textEticheta;
        }

        public PnlEticheta(string text)
        {
            this.text=text;
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public override string afisare()
        {
            string t = "--AFISARE ETICHETA--\n";

            t+=this.text+"\n";

            return t;

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
            return new PnlEticheta(this.text);
        }

    }
}
