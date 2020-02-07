using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;

        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;

        }
        public int GetLength()
        {
            return this.length;
        }
        public int SetLength(int len1)
        {
            this.length = len1;
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetWidth(int wid1)
        {
            this.width = wid1;
            return this.width;
        }

        public int GetPerimeter()
        {
            return (2 * (length + width));
        }
        public int GetArea()
        {
            return (length * width);
        }
    }
}
