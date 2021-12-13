using System;

namespace BilietavimoSistema
{
    class Program
    {
                   
        static void Main(string[] args)
        {
            BilietuAtaskaita ataskaita = new BilietuAtaskaita();


            while (true)
                    {
                Console.WriteLine("Meniu: spauskite 1 pirkti bilieta/us, 2 kurti bilieta/us, 3 gauti ataskaita ir 0 baigti programa");
                string pasirinkimas = Console.ReadLine();
                if (pasirinkimas == "1")
                {
                    Console.Write("Iveskite skaicius kiek norite pirkti bilietu ");
                    Console.Write("po 10 euru:");
                    int bil10 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("po 20 euru:");
                    int bil20 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("po 30 euru:");
                    int bil30 = Convert.ToInt32(Console.ReadLine());
                    ataskaita.PirktiBilietus(bil10, bil20, bil30);

                }
                else if (pasirinkimas == "2")
                {
                    Console.Write("Iveskite skaicius kiek norite sukurti bilietu ");
                    Console.Write("po 10 euru:");
                    int bil10 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("po 20 euru:");
                    int bil20 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("po 30 euru:");
                    int bil30 = Convert.ToInt32(Console.ReadLine());
                    ataskaita.KurtiBilietus(bil10, bil20, bil30);
                }
                else if (pasirinkimas == "3")
                {
                    ataskaita.Ataskaita();
                }
                else if (pasirinkimas == "0")
                {
                    Console.Write("Viso gero! ");
                    break; }



            }
        }
    }
}
