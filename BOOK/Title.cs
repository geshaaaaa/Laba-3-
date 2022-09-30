using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka3
{
    class Title
    {
        string nameoftitle = "";
        public string NameOftitle
        { set { nameoftitle = value; } get { return nameoftitle; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(NameOftitle);
        }



    }
}