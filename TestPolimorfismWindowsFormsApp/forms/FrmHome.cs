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

        public List<Panel> lista=new List<Panel>();

        public FrmHome()
        {
            InitializeComponent();

            Panel dreptunghi = new PnlDreptunghi(this);
            this.Controls.Add(dreptunghi);
            this.lista.Add(dreptunghi);



        }
    }
}
