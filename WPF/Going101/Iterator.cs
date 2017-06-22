using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going101
{
    interface Iterator<T>
    {
        void MoveNext();
        bool HasNext();
        T GetCurrent();
    }

    class Categories
    {
        public string Title;
        public string IconSource;
        public Type TargetType;

        public Categories(string _Title) //, string _IconSource, Type _TargetType)
        {
            this.Title = _Title;
            /*this.IconSource = _IconSource;
            this.TargetType = _TargetType;*/
        }
    }

    class CategoryItems
    {
        public string CategorieName;
        public string Topic;
        public string Description;
        public string ImageUrl;
        public Type TargetType;

        public CategoryItems(string _CategorieName, string _Topic, string _Description, string _ImageUrl, Type _TargetType)
        {
            this.CategorieName = _CategorieName;
            this.Topic = _Topic;
            this.Description = _Description;
            this.ImageUrl = _ImageUrl;
            this.TargetType = _TargetType;
        }
    }

    class CategorieIterator : Iterator<Categories>
    {
        public List<Categories> categories = new List<Categories>();

        private int index = -1;

        public CategorieIterator()
        {
            categories.Add(new Categories("Restaurants")); //0
            categories.Add(new Categories("Bar")); //1
            categories.Add(new Categories("Coffeeshop")); //2
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
