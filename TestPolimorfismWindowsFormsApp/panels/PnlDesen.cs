using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace TestPolimorfismWindowsFormsApp.panels
{
    internal class PnlDesen:PnlFigura
    {

        public List<PnlFigura> lista = new List<PnlFigura>();
        public FrmHome frmHome;
        public Button btnAfisare;
        public Button btnTranslateX;
        public Button btnTranslateY;
        public Button btnTranslateXY;
        public Random r=new Random();
        public Timer timer =new Timer();

        public PnlDesen(List<PnlFigura> lista,FrmHome frmHome)
        { 
            this.lista = lista;
            this.frmHome = frmHome;

            this.Location = new Point(12, 39);
            this.Size = new Size(776, 399);
            this.BackColor = Color.LightGreen;

            this.btnAfisare = new Button();
            this.Controls.Add(this.btnAfisare);
            this.btnAfisare.Location = new Point(13, 367);
            this.btnAfisare.Size = new Size(94, 29);
            this.btnAfisare.Text="Afisare";
            this.btnAfisare.Click+=new EventHandler(this.afisare_Click);

            this.btnTranslateX = new Button();
            this.Controls.Add(this.btnTranslateX);
            this.btnTranslateX.Location = new Point(113, 367);
            this.btnTranslateX.Size = new Size(94, 29);
            this.btnTranslateX.Text="translate x";
            this.btnTranslateX.Click+=new EventHandler(this.translateX_Click);

            this.btnTranslateY=new Button();
            this.Controls.Add(this.btnTranslateY);
            this.btnTranslateY.Location = new Point(213, 367);
            this.btnTranslateY.Size = new Size(94, 29);
            this.btnTranslateY.Text="translate y";
            this.btnTranslateY.Click+=new EventHandler(this.translateY_Click);

            this.btnTranslateXY=new Button();
            this.Controls.Add(this.btnTranslateXY);
            this.btnTranslateXY.Location = new Point(313, 367);
            this.btnTranslateXY.Size = new Size(134, 29);
            this.btnTranslateXY.Text="translate x si y";
            this.btnTranslateXY.Click+=new EventHandler(this.translateXY_Click);

        }

        public void afisare_Click(object sender,EventArgs e)
        {

            foreach(PnlFigura f in lista)
            {
                this.Controls.Add(f);
            }

        }

        public void translateX_Click(object sender,EventArgs e)
        {
           
            foreach (PnlFigura f in lista)
            {
                f.translateX(20);
            }
            this.timer.Enabled=true;
        }

        public void timer_Tick(object sender, EventArgs e)
        {

            

        }

        public void translateY_Click(object sender,EventArgs e)
        {
            foreach(PnlFigura f in lista)
            {
                f.translateY(20);
            }
        }

        public void translateXY_Click(object sender,EventArgs e)
        {

            foreach(PnlFigura f in lista)
            {
                f.translateYX(20, 20);
            }

        }

    }
}
