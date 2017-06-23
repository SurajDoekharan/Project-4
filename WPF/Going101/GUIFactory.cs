using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Going101
{
    abstract class GUIElement
    {
        public abstract string Title { get; }

        public virtual string GetText()
        {
            return "";
        }
    }

    class GUIButton : GUIElement
    {
        private string ButtonText;

        public override string Title
        {
            get
            {
                return "";
            }
        }

        public GUIButton(string ButtonText)
        {
            this.ButtonText = ButtonText;
        }

        public override string GetText()
        {
            return this.ButtonText;
        }
    }

    class GUIImage : GUIElement
    {
        public override string Title
        {
            get
            {
                return "";
            }
        }
    }

    class GUILabel : GUIElement
    {
        private string LabelText;

        //public GUILabel(Label LabelName, string LabelText, Color TextColor, Color BackgroundColor)

        public GUILabel(string LabelText)
        {
            this.LabelText = LabelText;
        }

        public override string Title
        {
            get
            {
                return "";
            }
        }

        public override string GetText()
        {
            return this.LabelText;
        }
    }


    static class GUIFactory
    {
        public static GUIElement initialize(int id)
        {
            switch (id)
            {
                case 0:
                    return new GUILabel("HOI");
                case 1:
                    return new GUIButton("lll");
                default:
                    return new GUIImage();

            }
        }
    }
}
