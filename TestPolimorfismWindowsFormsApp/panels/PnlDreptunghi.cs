using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlDreptunghi:PnlFigura
    {

        public Label lblTitlu;
        private PnlLinie linie1;
        private PnlLinie linie2;


        public PnlDreptunghi(PnlLinie linie1, PnlLinie linie2)
        {
            this.linie1=linie1;
            this.linie2=linie2;

            this.Location = new Point(linie1.A.X,linie1.A.Y);
            this.Size = new Size(172, 67);
            this.BackColor = Color.Coral;
            this.Name = "pnlDreptunghi";

            this.lblTitlu = new Label();
            this.Controls.Add(lblTitlu);
            this.lblTitlu.Location = new Point(39, 21);
            this.lblTitlu.Size = new Size(84, 20);
            this.lblTitlu.Text="Dreptunghi"; 

           
        }

        public PnlLinie Linie1
        {
            get { return this.linie1; }
            set { this.linie1 = value; }
        }

        public PnlLinie Linie2
        {
            get { return this.linie2; }
            set { this.linie2 = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE DREPTUNGHI--\nDreptunghiul este format din\n";

            PnlLinie l1 = linie1;
            PnlLinie l2 = linie2;

            text+="linie 1: punct "+l1.A.X+","+l1.A.Y;
            text+="linie 2: punct "+l2.A.X+","+l2.A.Y;

            return text;

        }

        public override void translateX(int x)
        {
            this.linie1.translateX(x);
            this.Location=this.linie1.A.Location;
        }

        public override void translateY(int y)
        {
            this.linie1.translateY(y);
            this.Location=this.linie1.A.Location;
        }

        public override void translateYX(int x, int y)
        {
            this.linie1.translateYX(x,y);
            this.Location=this.linie1.A.Location;
        }



    }
}
