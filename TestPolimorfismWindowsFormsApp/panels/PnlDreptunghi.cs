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
        public Button btnTRanslateX;
        public Button btnTRanslateY;
        public Button btnTRanslateXY;
        public Button btnDuplicare;
        public FrmHome frmHome;
        
        public PnlDreptunghi(FrmHome frmHome)
        {
            this.frmHome = frmHome;
            this.Location = new Point(104, 119);
            this.Size = new Size(330, 209);
            this.BackColor = Color.AliceBlue;
            this.Name = "pnlDreptunghi";

            this.lblTitlu = new Label();
            this.Controls.Add(lblTitlu);
            this.lblTitlu.Location = new Point(120, 24);
            this.lblTitlu.Size = new Size(84, 20);
            this.lblTitlu.Text="Dreptunghi"; 

            this.btnDuplicare = new Button();
            this.Controls.Add(this.btnDuplicare);
            this.btnDuplicare.Location = new Point(55, 163);
            this.btnDuplicare.Size = new Size(220, 29);
            this.btnDuplicare.Text="Duplicare";

            this.btnTRanslateX = new Button();
            this.Controls.Add(this.btnTRanslateX);
            this.btnTRanslateX.Location = new Point(55, 63);
            this.btnTRanslateX.Size = new Size(94, 29);
            this.btnTRanslateX.Text="Translate X";

            this.btnTRanslateY=new Button();
            this.Controls.Add(this.btnTRanslateY);
            this.btnTRanslateY.Location = new Point(181, 63);
            this.btnTRanslateY.Size = new Size(94, 29);
            this.btnTRanslateY.Text="Translate Y";

            this.btnTRanslateXY=new Button();
            this.Controls.Add(this.btnTRanslateXY);
            this.btnTRanslateXY.Location = new Point(100, 115);
            this.btnTRanslateXY.Size = new Size(134, 29);
            this.btnTRanslateXY.Text="Translate X si Y";

        }

        private PnlLinie linie1;
        private PnlLinie linie2;

        public PnlDreptunghi()
        {

        }

        public PnlDreptunghi(PnlLinie linie1, PnlLinie linie2)
        {
            this.linie1=linie1;
            this.linie2=linie2;
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

            text+="linie 1: punct 1 ("+l1.A.X+","+l1.A.Y+"), punct 2: ("+l1.B.X+","+l1.B.Y+")\n";
            text+="linie 2: punct 2 ("+l2.A.X+","+l2.A.Y+"), punct 2: ("+l2.B.X+","+l2.B.Y+")\n";

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
            return new PnlDreptunghi(this.linie1, this.linie2);
        }


    }
}
