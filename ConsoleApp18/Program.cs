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
        static void printprodukts( produkt[] pr)
        {

        }
        static void printallprodukts(produkt[] pr)
        {
            for (int i = 0; i < pr.Length; i++)
            {
                printprodukts(pr[i]);

            }
            Console.WriteLine("-----------------------------------------");
        }
        static void Main(string[] args)
        {
            produkt sv;
            sv.Name = "sirius";
            

           

            Console.WriteLine(sv.Name);
        }
    }
}
