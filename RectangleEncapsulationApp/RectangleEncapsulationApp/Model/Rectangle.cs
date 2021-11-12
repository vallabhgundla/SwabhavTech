using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int heigth;
        public int Validate(int diamention)
        {
            if (diamention<=100&&diamention>=1)
            {
                return diamention;
            }
            else if (diamention > 100)
            {
                return 100;
            }
            else if (diamention < 1)
            {
                return 1;
            }
            return diamention;
        }

        public void SetWidthAndHeight(int pwidth,int pheight)
        {
            width = Validate(pwidth);
            heigth = Validate(pheight);
        }
        public int Getwidth()
        {
            return width;
        }

        public int Getheight()
        {
            return heigth;
        }
   
    }
}