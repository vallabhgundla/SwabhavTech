using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleEncapsulationApp.model
{
   public class Circle
    {
         private String color;
         private int radius;

        public void SetRadius(int pradius)
        {
            if (radius < 1)
            {
                radius = 1;
            }
            else if (radius > 10)
            {
                radius = 10;
            }
            else
            {
                radius = pradius;
            }
        }
        public int GetRadius()
        {
            return radius;
        }

        public void SetColor(string pcolor)
        {
            if(pcolor == "Red" || pcolor == "Green" || pcolor == "Blue")
            {
                color = pcolor;
            }
            else
            {
                color = "Red";
            }
        }
        public string GetColor()
        {
            return color;
        }
       
    }
}
