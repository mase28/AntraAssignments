using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBalls
{
    public class Color
    {
        public int red { get; private set; }
        public int green { get; private set; }
        public int blue { get; private set; }
        public int alpha { get; private set; }


        public Color (int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = 255;
        }

        public void SetFromColor(Color c)
        {
            red = c.red;
            green = c.green;
            blue = c.blue;
            alpha = c.alpha;
        }

        public double GetGrayscale()
        {
            return (red + blue + green) / 3;
        }
    }
}
