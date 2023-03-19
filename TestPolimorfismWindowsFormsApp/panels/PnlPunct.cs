using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlPunct:PnlFigura
    {

        private Point point;

        public PnlPunct(int x, int y)
        {
            this.point = new Point(x, y);
        }

        public int X
        {
            get { return this.point.X; }
            set { this.point.X = value; }
        }

        public int Y
        {
            get { return this.point.Y; }
            set { this.point.Y = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE PUNCT--\n";

            text+="x="+this.point.X+" y="+this.point.Y+"\n";

            return text;
        }

        public override void translateX(int x)
        {
            this.point.X+=x;

            this.Location=this.point;
        }

        public override void translateY(int y)
        {
            this.point.Y+=y;
            this.Location=this.point;
        }

        public override void translateYX(int x, int y)
        {
            this.point.X+=x;
            this.point.Y+=y;
            this.Location=this.point;
        }


    }
}
