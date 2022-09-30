using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka3
{
    class Author
    {

        private string nameofauthor = "";
        public string NameOfauthor
        { set { nameofauthor = value; } get { return nameofauthor; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(NameOfauthor);
        }

    }
}
