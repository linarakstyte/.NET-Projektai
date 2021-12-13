using System;
using System.Collections.Generic;
using System.Text;

namespace BilietavimoSistema
{
    class BilietuAtaskaita
    {

        int _Bilietai10 = 0;
        int _Bilietai20 = 0;
        int _Bilietai30 = 0;
        int _VisoSukurta10 = 0;
        int _VisoSukurta20 = 0;
        int _VisoSukurta30 = 0;
        int _VisoParduota10 = 0;
        int _VisoParduota20 = 0;
        int _VisoParduota30 = 0;

        public void KurtiBilietus(int bil10, int bil20, int bil30)
        {
            _Bilietai10 += bil10;
            _Bilietai20 += bil20;
            _Bilietai30 += bil30;
            _VisoSukurta10 += bil10;
            _VisoSukurta20 += bil20;
            _VisoSukurta30 += bil30;
            Console.WriteLine($"Siuo metu yra {_Bilietai10} bilietai/u po 10 euru, {_Bilietai20} po 20 euru ir {_Bilietai30} po 30 euru");
        }

        public void PirktiBilietus(int bil10, int bil20, int bil30)
        {
            if (bil10 > _Bilietai10)
            { Console.WriteLine($"Siuo metu nera pakankamai {_Bilietai10} bilietu po 10 euru parduoti"); }
            else
            {
                _Bilietai10 -= bil10;
                _VisoParduota10 += bil10;
            }
            if (bil20 > _Bilietai20)
            { Console.WriteLine($"Siuo metu nera pakankamai {_Bilietai20} bilietu po 20 euru parduoti"); }
            else
            {
                _Bilietai20 -= bil20;
                _VisoParduota20 += bil20;
            }
            if (bil30 > _Bilietai30)
            { Console.WriteLine($"Siuo metu nera pakankamai {_Bilietai30} bilietu po 30 euru parduoti"); }
            else
            {
                _Bilietai30 -= bil30;
                _VisoParduota30 += bil30;
            }
            Console.WriteLine($"Siuo metu yra {_Bilietai10} bieltai/u po 10 euru, {_Bilietai20} po 20 euru ir {_Bilietai30} po 30 euru");
        }

        public void Ataskaita()
        {
            Console.WriteLine($"Is viso sukurta {_VisoSukurta10} bilietai/u po 10 euru, {_VisoSukurta20} po 20 euru ir {_VisoSukurta30} po 30 euru");
            Console.WriteLine($"Is viso parduoda {_VisoParduota10} bilietai/u po 10 euru, {_VisoParduota20} po 20 euru ir {_VisoParduota30} po 30 euru");


        }
    }
}
