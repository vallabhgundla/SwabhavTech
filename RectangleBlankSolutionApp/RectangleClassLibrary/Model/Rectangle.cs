using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleClassLibrary.Model
{
   public class Rectangle
    {
        private int _height;
        private int _width;
        private int _count = 0;

        private Rectangle(int height, int width)
        {
            this._height = height;
            this._width = width;
            _count += 1;

        }

        private int  GetHeight()
        {
            return _height;
        }
        private int GetWidth()
        {
            return _width;
        }
        private int GetCount()
        {
            return _count;
        }
    }
}
