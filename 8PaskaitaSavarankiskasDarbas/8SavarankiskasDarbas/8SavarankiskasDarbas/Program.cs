using MiskasStruct;
using PalmeStruct;
using SaskaitaStruct;
using System;
using System.Collections.Generic;

namespace _8SavarankiskasDarbas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            string SaskaitosNumeris()
            {
                Random rnd = new Random();
                int metai = rnd.Next(1900, 2021);
                int menuo = rnd.Next(1, 13);
                int diena = rnd.Next(1, 31);
                string saskaita = string.Format("NR_{0}_{1}_{2}_01", metai, menuo, diena);
                return saskaita;
            }

            var saskaita1 = new Saskaita("Jonas", "Petras", 2910, ($"{SaskaitosNumeris()}"));
            Console.WriteLine($"Gavejas {saskaita1._gavejas}, siuntejas {saskaita1._siuntejas}, reikia moketi {saskaita1._moketiViso} i saskaita {saskaita1._saskaitosNumeris}");
            #endregion

            #region
            Console.WriteLine("Koks palmes amzius (menesiu skaicius):");
            int amzius = Convert.ToInt32(Console.ReadLine());
            int vaisiuKiekis = 0;

            if (amzius < 5)
            {
                vaisiuKiekis = 0;
            }
            else if (5 < amzius & amzius < 12)
            {
                vaisiuKiekis = amzius * 3;
            }
            else amzius = 0;
            vaisiuKiekis = 0;

            var palme1 = new Palme(amzius, vaisiuKiekis);


            void Prideti1MenAmziaus()
            {
                if (palme1._amzius < 12 & palme1._amzius != 0)
                { Console.WriteLine($"Palmes amzius uz menesio bus {palme1._amzius + 1} ir ji duos {vaisiuKiekis} vaisiu/s."); }

                else Console.WriteLine($"Palme uz menesio bus mirus");

            }
            Prideti1MenAmziaus();
            #endregion

            Miskas medziuSarasas1 = new Miskas();

            medziuSarasas1.PasodintiMedi();


        }


    }
}

