using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlDesen:PnlFigura
    {

        public List<PnlFigura> lista = new List<PnlFigura>();
        public FrmHome frmHome;
        public Button btnAfisare;
        public Button btnTranslateX;
        public Button btnTranslateY;
        public Button btnTranslateXY;
        public Random r=new Random();
        public Timer time =new Timer();
        public Timer time2=new Timer();
        public Timer time3=new Timer();
        public Label lbl1;
        public Label lbl2;
        public Label lbl3;
        public TextBox txt1;
        public TextBox txt2;
        public TextBox txt3;
        public Button btnAdaugare;
        public Label lbladaugare;
        public TextBox txtadaugare;


        public PnlDesen(List<PnlFigura> lista,FrmHome frmHome)
        { 
            this.lista = lista;
            this.frmHome = frmHome;

            this.Location = new Point(12, 12);
            this.Size = new Size(776, 426);

            this.btnAfisare = new Button();
            this.Controls.Add(this.btnAfisare);
            this.btnAfisare.Location = new Point(13, 392);
            this.btnAfisare.Size = new Size(94, 29);
            this.btnAfisare.Text="Afisare";
            this.btnAfisare.Click+=new EventHandler(this.afisare_Click);

            this.btnTranslateX = new Button();
            this.Controls.Add(this.btnTranslateX);
            this.btnTranslateX.Location = new Point(136, 392);
            this.btnTranslateX.Size = new Size(94, 29);
            this.btnTranslateX.Text="translate x";
            this.btnTranslateX.Click+=new EventHandler(this.translateX_Click);

            this.btnTranslateY=new Button();
            this.Controls.Add(this.btnTranslateY);
            this.btnTranslateY.Location = new Point(325, 392);
            this.btnTranslateY.Size = new Size(94, 29);
            this.btnTranslateY.Text="translate y";
            this.btnTranslateY.Click+=new EventHandler(this.translateY_Click);

            this.btnTranslateXY=new Button();
            this.Controls.Add(this.btnTranslateXY);
            this.btnTranslateXY.Location = new Point(524, 392);
            this.btnTranslateXY.Size = new Size(134, 29);
            this.btnTranslateXY.Text="translate x si y";
            this.btnTranslateXY.Click+=new EventHandler(this.translateXY_Click);

            this.lbl1=new Label();
            this.Controls.Add(this.lbl1);
            this.lbl1.Location = new Point(136, 356);
            this.lbl1.Size = new Size(109, 20);
            this.lbl1.Text="translatare x cu";

            this.lbl2 =new Label();
            this.Controls.Add(this.lbl2);
            this.lbl2.Location = new Point(325, 359);
            this.lbl2.Size = new Size(109, 20);
            this.lbl2.Text="translatare y cu";

            this.lbl3 =new Label();
            this.Controls.Add(this.lbl3);
            this.lbl3.Location = new Point(524, 363);
            this.lbl3.Size = new Size(134, 20);
            this.lbl3.Text="translatare x si y cu";

            this.txt1=new TextBox();
            this.Controls.Add(this.txt1);
            this.txt1.Location = new Point(251, 356);
            this.txt1.Size=new Size(42, 27);
            
            this.txt2 =new TextBox();
            this.Controls.Add(this.txt2);
            this.txt2.Location = new Point(440, 359);
            this.txt2.Size=new Size(42, 27);

            this.txt3 =new TextBox();
            this.Controls.Add(this.txt3);
            this.txt3.Location = new Point(664, 363);
            this.txt3.Size=new Size(42, 27);

            this.btnAdaugare=new Button();
            this.Controls.Add(this.btnAdaugare);
            this.btnAdaugare.Location=new Point(325, 306);
            this.btnAdaugare.Size=new Size(131, 29);
            this.btnAdaugare.Text="adaugare figura";
            this.btnAdaugare.Click+=new EventHandler(this.btnAdaugare_Click);

            this.lbladaugare=new Label();
            this.Controls.Add(this.lbladaugare);
            this.lbladaugare.Location=new Point(13, 306);
            this.lbladaugare.Size=new Size(166, 20);
            this.lbladaugare.Text="ce figura vrei sa adaugi";

            this.txtadaugare=new TextBox();
            this.Controls.Add(this.txtadaugare);
            this.txtadaugare.Location=new Point(185, 306);
            this.txtadaugare.Size = new Size(122, 27);


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
                this.time.Enabled=true;
                this.time.Tick+=new EventHandler(this.time_Tick);   
            }
            
        }

        public void translateY_Click(object sender,EventArgs e)
        {
            foreach(PnlFigura f in lista)
            {
                this.time2.Enabled=true;
                this.time2.Tick+=new EventHandler(this.time2_Tick);
            }
        }

        public void translateXY_Click(object sender,EventArgs e)
        {

            foreach(PnlFigura f in lista)
            {
                this.time3.Enabled=true;
                this.time3.Tick+=new EventHandler(this.timer3_Tick);
            }

        }

        public void time_Tick(object sender,EventArgs e)
        {

            int k = int.Parse(this.txt1.Text);

            foreach(PnlFigura f in lista)
            {
                f.Left+=k;

                if (f.Left+f.Width>=this.Width)
                {
                    this.time.Enabled=false;
                }

            }



        }

        public void time2_Tick(object sender,EventArgs e)
        {
            int k = int.Parse(this.txt2.Text);

            foreach (PnlFigura f in lista)
            {
                f.Top+=k;

                if (f.Top+f.Height>=this.Height)
                {
                    this.time2.Enabled=false;
                }

            }

        }

        public void timer3_Tick(object sender, EventArgs e)
        {

            int k = int.Parse(this.txt3.Text);

            foreach (PnlFigura f in lista)
            {
                f.Left+=k;
                f.Top+=k;

                if (f.Top+f.Height>=this.Height||f.Left+f.Width>=this.Width)
                {
                    this.time3.Enabled=false;
                }
            }

        }

        public void btnAdaugare_Click(object sender,EventArgs e)
        {

            if (this.txtadaugare.Text.Equals("dreptunghi"))
            {
                PnlPunct punct = new PnlPunct(70, 67);
                PnlLinie linie = new PnlLinie(punct);
                PnlDreptunghi nou = new PnlDreptunghi(linie, linie);
                nou.BackColor=Color.Green;

                this.Controls.Add(nou);
                this.lista.Add(nou);
            }
            else if(this.txtadaugare.Text.Equals("cerc"))
            {
                PnlPunct punct = new PnlPunct(218, 50);
                PnlLinie linie = new PnlLinie(punct);
                PnlCerc cerc = new PnlCerc(punct, linie);
                cerc.BackColor=Color.Pink;

                this.Controls.Add(cerc);
                this.lista.Add(cerc);
            }
            else
            {
                MessageBox.Show("figura inexistenta");
            }

        }

    }
}
