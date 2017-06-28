
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Going101.Views.Main;
using static Going101.Views.Main.MainView;

namespace Going101.ViewControllers.Main
{
    class MainController
    {
        public MainView View { get; private set; }

        public MainController(MainView view)
        {
            View = view;
        }
    }
}
