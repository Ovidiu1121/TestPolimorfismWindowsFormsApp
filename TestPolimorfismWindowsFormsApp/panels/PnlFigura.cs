using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolimorfismWindowsFormsApp.panels
{
    public class PnlFigura:Panel
    {

        public virtual string afisare()
        {
            return "";
        }

        public virtual void translateX(int x)
        {
            
        }

        public virtual void translateY(int y)
        {
            
        }

        public virtual void translateYX(int x, int y)
        {
            
        }

       

    }
}
