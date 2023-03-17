using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlPunct:PnlFigura
    {

        private double x;
        private double y;

        public PnlPunct()
        {

        }

        public PnlPunct(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public PnlPunct(string prop)
        {
            string[] a = prop.Split(",");

            this.x = double.Parse(a[0]);
            this.y = double.Parse(a[1]);

        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE PUNCT--\n";

            text+="x="+this.x+" y="+this.y+"\n";

            return text;
        }

        public override void translateX(int x)
        {
            this.x+=x;
        }

        public override void translateY(int y)
        {
            this.y+=y;
        }

        public override void translateYX(int x, int y)
        {
            this.x+=x;
            this.y+=y;
        }

        public override PnlFigura duplicare()
        {
            return new PnlPunct(this.x, this.y);
        }

    }
}
