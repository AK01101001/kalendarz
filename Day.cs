using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace kalendarz
{
    internal class Day
    {
        public int id;
        public ImageSource imageSource;

        public Day(int id, ImageSource imageSource)
        {
            this.id = id;
            this.imageSource = imageSource;
        }

    }
}
