using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Going101
{
    class WpfElements
    {
        public List<Control> elements = new List<Control>();

        public List<Image> Image = new List<Image>();

        public void AddButton(ElementType Element, string Buttontext, SolidColorBrush ButtonColor, SolidColorBrush TextColor, Thickness Margin)
        {
            Button button = new Button();

            button.Content = Buttontext;

            button.Background = ButtonColor;

            button.Foreground = TextColor;

            button.Margin = Margin;

            elements.Add(button);
        }

        public void AddLabel(ElementType Element, string LabelText, SolidColorBrush LabelColor, SolidColorBrush TextColor, int FontSize, Thickness Margin)
        {
            Label label = new Label();

            label.Content = LabelText;

            label.Background = LabelColor;

            label.Foreground = TextColor;

            label.Margin = Margin;

            label.FontSize = FontSize;

            elements.Add(label);

        }

        public void AddImage(ElementType Element, ImageSource imageurl)
        {
            Image image = new Image();

            image.Source = imageurl;

            Image.Add(image);
        }

        /*public void AddImageCell(ElementType Element, ImageSource ImageCellSource, string ImageCellText, string ImageCellSecondaryText)
        {
            ImageCell imagecell = new ImageCell();

            imagecell.ImageSource = ImageCellSource;

            imagecell.Text = ImageCellText;

            imagecell.Detail = ImageCellSecondaryText;

            ImageCells.Add(imagecell);

        }*/
    }
}
