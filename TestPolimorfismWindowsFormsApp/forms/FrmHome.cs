using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPolimorfismWindowsFormsApp.panels;

namespace TestPolimorfismWindowsFormsApp
{
    public partial class FrmHome : Form
    {
        public List<PnlFigura> lista=new List<PnlFigura>();

        public FrmHome()
        {
            InitializeComponent();


            PnlPunct punct = new PnlPunct(13, 3);
            PnlLinie linie = new PnlLinie(punct);
            PnlCerc cerc=new PnlCerc(punct,linie);
            this.lista.Add(cerc);
            
            PnlPunct punctDr=new PnlPunct(121, 3);
            PnlLinie linieDr=new PnlLinie(punctDr);
            PnlDreptunghi dreptunghi = new PnlDreptunghi(linieDr, linie);
            this.lista.Add(dreptunghi);

            PnlDesen desen = new PnlDesen(this.lista,this);
            this.Controls.Add(desen);
            
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
