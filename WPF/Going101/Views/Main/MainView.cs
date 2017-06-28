using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Going101.ViewControllers.Main;
using System.Windows.Controls;

using static Going101.WpfElements;
using static Going101.ViewControllers.Main.MainController;
using System.Windows.Media;

namespace Going101.Views.Main
{
    public class MainView : Page, IView
    {
        Grid parent = new Grid();

        Grid tableview = null;

        private MainController Controller { get; set; }

        public MainView()
        {
            InitLayout();

            Background = Brushes.Black;

            Title = "Going010";

            Controller = new MainController(this);
        }

        public void InitLayout()
        {

            WpfElements Creator = new WpfElements();

            GUIElement MainPageLabel = GUIFactory.initialize(ElementType.MainPageLabel);
            GUIElement MainPageImage = GUIFactory.initialize(ElementType.MainPageImage);
            GUIElement LoginButtonMainPage = GUIFactory.initialize(ElementType.LoginButtonMainPage);
            /*GUIElement FirstImageCell = GUIFactory.initialize(ElementType.FirstImageCell);
            GUIElement SecondImageCell = GUIFactory.initialize(ElementType.SecondImageCell);
            GUIElement ThirdImageCell = GUIFactory.initialize(ElementType.ThirdImageCell);*/


            Creator.AddImage(ElementType.MainPageImage, MainPageImage.GetImageSource());
            /*
            Creator.AddImageCell(ElementType.FirstImageCell, FirstImageCell.GetImageSource(), FirstImageCell.GetText(), FirstImageCell.GetSecondaryText());
            Creator.AddImageCell(ElementType.SecondImageCell, SecondImageCell.GetImageSource(), SecondImageCell.GetText(), SecondImageCell.GetSecondaryText());
            Creator.AddImageCell(ElementType.ThirdImageCell, ThirdImageCell.GetImageSource(), ThirdImageCell.GetText(), ThirdImageCell.GetSecondaryText());
            */
            Creator.AddButton(ElementType.LoginButtonMainPage, LoginButtonMainPage.GetText(), LoginButtonMainPage.GetBackgroundColor(), LoginButtonMainPage.GetTextColor(), MainPageLabel.GetMargin());

            this.Content = parent;
            
            foreach (Control element in Creator.elements)
            {
                parent.Children.Add(element);
            }

        }
    }
}
