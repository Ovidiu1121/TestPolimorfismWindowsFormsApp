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
        private PnlLinie linie;

        public Label lblEticheta;
        public Button btnAfisare;

        public PnlCerc(PnlPunct b, PnlLinie linie)
        {
            this.linie=linie;
            this.b=b;
            this.Location = new Point(b.X, b.Y);
            this.Size=new Size(131, 78);
            this.Name="pnlCerc";
            this.BackColor=Color.Orange;

            this.lblEticheta=new Label();
            this.Controls.Add(this.lblEticheta);
            this.lblEticheta.Location=new Point(44, 30);
            this.lblEticheta.Size=new Size(38, 20);
            this.lblEticheta.Text="Cerc";

        }

        public PnlPunct B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public PnlLinie Linie
        {
            get { return this.linie; }
            set { this.linie = value; }
        }

        public override string afisare()
        {
            string text = "--AFISARE CERC--\nCercul este format din\n";

            PnlPunct p = b;
            PnlLinie l = linie;

            text+="punct: ("+p.X+","+p.Y+")\n"+"linie: punct "+l.A.X+","+l.A.Y;

            return text;
        }

        public override void translateX(int x)
        {
            this.b.translateX(x);
            this.Location=this.b.Location;
        }

        public override void translateY(int y)
        {
            this.b.translateY(y);
            this.Location=this.b.Location;
        }

        public override void translateYX(int x, int y)
        {
            this.b.translateYX(x, y);
            this.Location=this.b.Location;
        }

        public void afisare_Click(object sender, EventArgs e)
        {
            string text = "--AFISARE CERC--\nCercul este format din\n";

            text+="punct: ("+this.b.X+","+this.b.Y+")\n"+"linie: "+this.linie.A.X+","+this.linie.A.Y;

            MessageBox.Show(text);

        }



    }
}
