using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd4
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
            
         
            switch (Article)
            {
                case "PDV":
                    {
                        fee = 0.20;
                        sum = (account * quantity) * fee;
                        break;
                    }
                case "No PDV":
                    {
                        sum += account * quantity;
                        break;
                    }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ціна товару, отримувач, постачальник:");
            Invoice invoice = new Invoice(5000, "Hennadii", "Rozetka");
            Console.WriteLine("Кількість товару: ");
            int quantity = int.Parse(Console.ReadLine());
            invoice.Quantity = quantity;
            Console.WriteLine("PDV");
            Console.WriteLine("No PDV");
            string article = Console.ReadLine();
            invoice.Article = article;
            Console.WriteLine(invoice.fee());
        }
    }
}