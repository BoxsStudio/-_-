using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static int currentProductId = 0;
        struct Produkt
        {
            public int Id;
            public string Name;
            public string Contracton;
            public DateTime DeliveryDate;
            public int SelfLifeDays;
            public int Balanse;
        }

        static void ResizeArray(ref Produkt[] products, int newLength)
        {
            Produkt[] newArray = new Produkt[products.Length+1];
            for (int i = 0; i < products.Length; i++)
            {
                newArray[i] = products[i];
            }
            products = newArray;
        }
        static void InsertNewProdukt(ref Produkt[] products, Produkt produkt)
        {
            if (products == null)
            {
                products = new Produkt[1];
                products[0] = produkt;
            }
            else
            {
                ResizeArray(ref products, products.Length + 1);
                products[products.Length - 1] = produkt;
            }
        }
        static Produkt CreteProdukt ()
        {
            Produkt produkt;
            Console.WriteLine("введите название продукта");
            produkt.Name = Console.ReadLine();

            Console.WriteLine("введите поставщика");
            produkt.Contracton = Console.ReadLine();

            Console.WriteLine("введите дату");
            produkt.DeliveryDate = DateTime.Parse( Console.ReadLine());

            Console.WriteLine("введите срок годности");
            produkt.SelfLifeDays = int.Parse(Console.ReadLine());

            Console.WriteLine("введите остаток продукта");
            produkt.Balanse = int.Parse(Console.ReadLine());

            currentProductId++;
            produkt.Id = currentProductId;

            return produkt;
        }
        static void PrintProdukt(Produkt produkt)
        {
            Console.WriteLine("{0, -3}{1,-15}{2,-15}{3, -12}{4, -4}{5, -4}", produkt.Id, produkt.Name, produkt.Contracton, produkt.DeliveryDate.Date.ToShortDateString(), produkt.SelfLifeDays, produkt.Balanse);
        }
        static void PrintAllProdukts(Produkt[] produkt)
        {
            Console.WriteLine("{0, -3}{1,-15}{2,-15}{3, -12}{4, -4}{5, -4}", "ИД","название","поставщик","дата доставки.","сг","ост");
            for (int i = 0; i < produkt.Length; i++)
            {
                PrintProdukt(produkt[i]);

            }
            Console.WriteLine("-----------------------------------------");
        }
        static void Main(string[] args)
        {
            Produkt[] produks = null;

            InsertNewProdukt(ref produks, CreteProdukt());
            InsertNewProdukt(ref produks, CreteProdukt());

            PrintAllProdukts(produks);
            Console.ReadKey();

        }
    }
}
