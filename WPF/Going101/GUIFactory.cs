using System;
using System.Windows.Media;

namespace Going101
{


    abstract class GUIElement
    {
        public abstract string Title { get; }

        public virtual string GetText() { return ""; }

        public virtual SolidColorBrush GetBackgroundColor() { return Brushes.White; }

        public virtual SolidColorBrush GetTextColor() { return Brushes.White; }

        public virtual string GetSecondaryText() { return ""; }

        public virtual string GetImageSource() { return ""; }

        public virtual int GetFontSize() { return 20; }

        public virtual int GetMargin() { return 20; }
    }

    //BUTTON CONTENT

    class GUIButton : GUIElement
    {
        public override string Title { get { return ""; } }

        private string ButtonText;

        private SolidColorBrush ButtonColor;

        private SolidColorBrush TextColor;

        private int Margin;

        public GUIButton(string ButtonText, SolidColorBrush ButtonColor, SolidColorBrush TextColor, int Margin)
        {
            this.ButtonText = ButtonText;
            this.ButtonColor = ButtonColor;
            this.TextColor = TextColor;
            this.Margin = Margin;
        }

        public override string GetText()
        {
            return this.ButtonText;
        }

        public override SolidColorBrush GetBackgroundColor()
        {
            return this.ButtonColor;
        }

        public override SolidColorBrush GetTextColor()
        {
            return this.TextColor;
        }

        public override int GetMargin()
        {
            return this.Margin;
        }

    }

    //IMAGE CONTENT

    class GUIImage : GUIElement
    {
        public override string Title { get { return ""; } }

        private ImageSource ImageUrl;

        public GUIImage(ImageSource ImageUrl)
        {
            this.ImageUrl = ImageUrl;
        }

        public override string GetImageSource()
        {
            return this.ImageUrl.ToString();
        }
    }

    //LABEL CONTENT

    class GUILabel : GUIElement
    {

        public override string Title { get { return ""; } }

        private string LabelText;

        private SolidColorBrush LabelColor;

        private SolidColorBrush TextColor;

        private int FontSize;

        private int Margin;

        public GUILabel(string LabelText, SolidColorBrush LabelColor, SolidColorBrush TextColor, int FontSize, int Margin)
        {
            this.LabelText = LabelText;

            this.LabelColor = LabelColor;

            this.TextColor = TextColor;

            this.FontSize = FontSize;

            this.Margin = Margin;
        }

        public override string GetText()
        {
            return this.LabelText;
        }

        public override SolidColorBrush GetTextColor()
        {
            return this.TextColor;
        }

        public override SolidColorBrush GetBackgroundColor()
        {
            return this.LabelColor;
        }

        public override int GetFontSize()
        {
            return this.FontSize;
        }

        public override int GetMargin()
        {
            return this.Margin;
        }
    }

    //IMAGECELLCONTENT

    class GUIImageCell : GUIElement
    {
        public override string Title { get { return ""; } }

        private string IconSource;

        private string ImageCellText;

        private string ImageCellSecondaryText;

        public GUIImageCell(string IconSource, string ImageCellText, string ImageCellSecondaryText)
        {
            this.IconSource = IconSource;

            this.ImageCellText = ImageCellText;

            this.ImageCellSecondaryText = ImageCellSecondaryText;
        }

        public override string GetImageSource()
        {
            return this.IconSource;
        }

        public override string GetText()
        {
            return this.ImageCellText;
        }

        public override string GetSecondaryText()
        {
            return this.ImageCellSecondaryText;
        }

    }

    public enum ElementType
    {
        MainPageLabel,
        LoginButtonMainPage,
        ImageCellCategory,
        MainPageImage,
        FirstImageCell,
        SecondImageCell,
        ThirdImageCell
    }

    static class GUIFactory
    {
        public static GUIElement initialize(ElementType et)
        {
            switch (et)
            {
                case ElementType.MainPageImage:
                    return new GUIImage("appfrontpage.jpg");
                case ElementType.MainPageLabel:
                    return new GUILabel("Welcome to Going010. This is THE place to find all the best spots to go out, have dinner , chill and have fun. We Compiled the best places in just one simple app. Go Wild go 010!", Brushes.Black, Brushes.DarkGoldenrod, 18, 40);
                case ElementType.FirstImageCell:
                    return new GUIImageCell("appfrontpage.jpg", "BEST RATED", "Villa Thalia Rotterdam");
                case ElementType.SecondImageCell:
                    return new GUIImageCell("icon.png", "2ND BEST RATED", "helemaal nix");
                case ElementType.ThirdImageCell:
                    return new GUIImageCell("appfrontpage.jpg", "3RD BEST RATED", "helemaal nix");
                case ElementType.LoginButtonMainPage:
                    return new GUIButton("Login to rate places", Brushes.DarkGoldenrod, Brushes.Black, 20);
                default:
                    return null;
            }
        }
    }
}
