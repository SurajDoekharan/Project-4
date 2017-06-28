using Going101;
using Going101.Views.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going010Applicatie
{
    interface Iterator<T>
    {
        void MoveNext();
        bool HasNext();
        T GetCurrent();
    }

    class Categories
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }

        public Categories(string _Title, string _IconSource, Type _TargetType)
        {
            this.Title = _Title;
            this.IconSource = _IconSource;
            this.TargetType = _TargetType;

        }
    }

    class CategorieItems
    {
        public string CategorieName;
        public string Topic;
        public string Description;
        public string ImageUrl;
        public Type TargetType;

        public CategorieItems(string _CategorieName, string _Topic, string _Description, string _ImageUrl, Type _TargeType)
        {
            this.CategorieName = _CategorieName;
            this.Topic = _Topic;
            this.Description = _Description;
            this.ImageUrl = _ImageUrl;
            this.TargetType = _TargeType;
        }

    }

    class CategorieIterator : Iterator<Categories>
    {
        public List<Categories> categories = new List<Categories>();

        private int index = -1;

        public CategorieIterator()
        {
            categories.Add(new Categories("010 Coffeeshops", "icon.png", typeof(MainView)));
            categories.Add(new Categories("010 Bars", "icon.png", typeof(CoffeeshopPage)));
            categories.Add(new Categories("010 Cafes", "icon.png", typeof(MainView)));
        }
        public void MoveNext()
        {
            index++;
        }
        public bool HasNext()
        {
            return index < categories.Count - 1;
        }

        public Categories GetCurrent()
        {
            return categories[index];
        }
    }

}
