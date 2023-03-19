using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlEticheta:PnlDreptunghi
    {
        public Label lblText;
        private PnlPunct point;

        public PnlEticheta(PnlPunct punct,PnlLinie linie1, PnlLinie linie2) : base(linie1, linie2)
        {
            this.point=punct;
            this.Location = new Point(punct.X,punct.Y);
            this.Size = new Size(164, 59);
            this.Name="pnlEticheta";
            this.BackColor = Color.CornflowerBlue;

            this.lblText=new Label();
            this.Controls.Add(this.lblText);
            this.lblText.Location=new Point(50, 21);
            this.lblText.Size=new Size(62, 20);
            this.lblText.Text="Eticheta";

        }

        public PnlPunct Point
        {
            get { return this.point; }
            set { this.point = value; }
        }

        public override void translateX(int x)
        {
            this.point.translateX(x);
            this.Location=this.point.Location;
        }

        public override void translateY(int y)
        {
            this.point.translateY(y);
            this.Location=this.point.Location;
        }

        public override void translateYX(int x, int y)
        {
            this.point.translateYX(x,y);
            this.Location=this.point.Location;
        }

    }
}
