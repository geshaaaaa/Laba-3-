using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka3
{
    internal class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        private double summa;
        public double Summa
        {
            get { return summa; }
            set { summa = value; }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public double fee()
        {
            double fee = 0;
            double sum = 0;           
            int price = 1200;
            quantity = 3;         
            switch (Article)
            {
                case "PDV":
                    {
                        fee = 0.20;
                        sum = (price * quantity) * fee;
                        break;
                    }
                case "No PDV":
                    {
                        sum = price * quantity;
                        break;
                    }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(5000, "Hennadii", "Rozetka");
            Console.WriteLine("PDV");
            Console.WriteLine("No PDV");
            string article = Console.ReadLine();
            invoice.Article = article;
            Console.WriteLine(invoice.fee());
        }
    }
}