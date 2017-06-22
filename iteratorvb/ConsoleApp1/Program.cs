using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going010Applicatie
{
    interface ITerator<T>
    {
        void MoveNext();
        bool HasNext();
        T GetCurrent();
    }
    class Categories
    {
        public string Title;
        //public string IconSource;
        //public Type TargetType;

        public Categories(string _Title) //string _IconSource, Type _TargetType)
        {
            this.Title = _Title;

            //this.IconSource = _IconSource;
            //this.TargetType = _TargetType;

        }
    }

    class CategorieItems
    {
        public string CategorieName;
        public string Topic;
        public string Discription;
        public string ImageUrl;
        public Type TargetType;

        public CategorieItems(string _CategorieName, string _Topic, string _Discription, string _ImageUrl, Type _TargetType)
        {
            this.CategorieName = _CategorieName;
            this.Topic = _Topic;
            this.Discription = _Discription;
            this.ImageUrl = _ImageUrl;
            this.TargetType = _TargetType;

        }
    }

    class CategorieIterator : ITerator<Categories>
    {
        private List<Categories> categories = new List<Categories>();
        private int index = -1;
        public CategorieIterator()
        {
            categories.Add(new Categories("Restaurants"));
            categories.Add(new Categories("Bars"));
            categories.Add(new Categories("Coffeeshops"));
        }
        public void MoveNext()
        {
            index++;
        }
        public bool HasNext()
        {
            return index < categories.Count -1;
        }
        public Categories GetCurrent()
        {
            return categories[index];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var iterator = new CategorieIterator();

            while (iterator.HasNext())
            {
                iterator.MoveNext();
                Console.WriteLine(iterator.GetCurrent().Title);
                Console.ReadKey();
            }
        }

    }
}
