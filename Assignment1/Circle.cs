﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Circle : Interface1
    {
        public void drawShape(string[] res, Graphics g, int a, int b)
        {
            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[1]);
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, a, b, c, d);
        }
    }
}
