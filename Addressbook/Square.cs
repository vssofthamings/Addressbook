using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    class Square
    {
        private int size;
        private bool colored = false;

        public Square(int size)
        {
            this.size = size;
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public bool Colored
        {
            get
            {
                return colored;
            }
            set
            {
                colored = value;
            }
        }

    }
}
