using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBalls
{
    public class Ball
    {
        public int size { get; private set; }
        public Color c { get; private set; }

        private int thrown = 0;

        public Ball(int size, Color c)
        {
            this.size = size;
            this.c = c;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                thrown++;
            }
        }

        public int GetThrown()
        {
            return thrown;
        }
    }
}
