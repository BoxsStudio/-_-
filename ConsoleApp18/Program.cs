using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static int current_id = 0;
        struct produkt
        {
            public int Id;
            public string Name;
            public string Contracton;
            public DateTime DeliveryDate;
            public int SelfLifeDays;
            public int Balanse;
        }

        static void ResizeArray(ref produkt[] pr, int newLength)
        {
            int mitLength = newLength > pr.Length ? pr.Length : newLength;
            produkt[] newArray = new produkt[mitLength];
            for (int i = 0; i < mitLength; i++)
            {
                newArray[i] = pr[i];
            }
            pr = newArray;
        }
        static void newprodukts(ref produkt[] pr, produkt produkt)
        {
            if (pr == null)
            {
                pr = new produkt[1];
                pr[0] = produkt;
            }
            else
            {
                ResizeArray(ref pr, pr.Length + 1);
            }
            pr[pr.Length - 1] = produkt;
        }
        static produkt creteprodact ()
        {
            produkt pur;
            Console.WriteLine("введите название продукта");
            pur.Name = Console.ReadLine();

            Console.WriteLine("введите поставщика");
            pur.Contracton = Console.ReadLine();

            Console.WriteLine("введите дату");
            pur.DeliveryDate = DateTime.Parse( Console.ReadLine());

            Console.WriteLine("введите срок годности");
            pur.SelfLifeDays = int.Parse(Console.ReadLine());

            Console.WriteLine("введите остаток продукта");
            pur.Balanse = int.Parse(Console.ReadLine());

            pur.Id = 0;

            return pur;
        }
        static void printprodukts( produkt pr)
        {
            Console.WriteLine("{0, -3}{1,-15}{2,-15}{3, -12}{4, -4}{5, -4}", pr.Id, pr.Name, pr.Contracton, pr.DeliveryDate.Date, pr.SelfLifeDays, pr.Balanse);
        }
        static void printallprodukts(produkt[] pr)
        {
            Console.WriteLine("{0, -3}{1,-15}{2,-15}{3, -12}{4, -4}{5, -4}", "ИД","название","поставщик","дата доставки.","сг","ост");
            for (int i = 0; i < pr.Length; i++)
            {
                printprodukts(pr[i]);

            }
            Console.WriteLine("-----------------------------------------");
        }
        static void Main(string[] args)
        {
            produkt[] pr = null;

            InsertNewProdact(ref pr, creteprodact());
            InsertNewProdact(ref pr, creteprodact());
            printallprodukts(pr);
            Console.ReadKey();

        }
    }
}
