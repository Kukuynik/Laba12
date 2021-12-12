using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Laba12
{
    abstract class Figure
    {
        private string[] colors = { "Red", "Blue", "Yellow", "Black" };
        private bool visible = true;

        public Figure()
        {

        }
        public abstract void Draw(PictureBox pic)
    }
}
