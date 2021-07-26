using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DrawTo: Interface1 
    {
        public void drawShape(string[] res, Graphics g, int k, int l)
        {
            int a = Convert.ToInt32(res[1]);
            int b = Convert.ToInt32(res[2]);
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, k, l, a, b);
        }
        }
}
