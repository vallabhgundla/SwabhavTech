using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    public class Rectangle
    {
      public  int width = 0;
      public  int height = 0;

        public int CalculateArea()
        {
            int area = width * height;
            return area;

        }

    }
}
