using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;

namespace libarysystem_WpfApp
{
    internal interface IIventory
    {
        public string ISBN { get => ""; set => ""; }
        public string Title { get => throw new NotImplementedException(); set => throw NotImplementedException(); }

        public void addItem()
        {
            //add items here
        }
        public void deleteItem()
        {
            //
        }
        public void rentItem()
        {

        }
        public void returnItem()
        {

        }
        public void Journal(string L_ISBN, string L_Title)
        {
            ISBN = L_ISBN;
            Title = L_Title;
        }

    }
 
}
