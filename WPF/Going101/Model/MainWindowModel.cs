using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going101.Model
{
    class MainWindowModel
    {
        
        public MainWindowModel(string Cat)
        {
            Category = Cat;
        }

        private string _Category;
        public String Category
        {
            get
            {
                return _Category;
            }
            set
            {
                _Category = value;
            }
        }
    }
}
