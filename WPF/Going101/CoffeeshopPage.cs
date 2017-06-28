using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Going101
{
    class CoffeeshopPage : Page, IView
    {
        public CoffeeshopPage()
        {
            Background = Brushes.Black;

            Title = "Going010";
        }

        public void InitLayout()
        {
            return;
        }
    }
}
