using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka3
{
    class Book
    {





        static void Main(string[] args)
        {

            Title title = new Title();
            title.NameOftitle = "Seven";


            Content content = new Content();
            content.NameOfcontent = "Psychological crime thriller film.";


            Author author = new Author();
            author.NameOfauthor = "David Fincher";

            title.Show();
            content.Show();
            author.Show();
        }
    }
}