using System;

namespace SaskaitaStruct
{
    public struct Saskaita
    {
        public string _gavejas;
        public string _siuntejas;
        public int _moketiViso;
        public string _saskaitosNumeris;

        public string Gavejas
        {
            get
            {
                return _gavejas;
            }

            set
            {
                _gavejas = value;
            }
        }

        public string Siuntejas
        {
            get
            {
                return _siuntejas;
            }

            set
            {
                _siuntejas = value;

            }
        }

        public int MoketiViso
        {
            get
            {
                return _moketiViso;
            }

            set
            {
                _moketiViso = value;
            }
        }


        public string SaskaitosNumeris()
        {
            Random rnd = new Random();
            int metai = rnd.Next(1900, 2021);
            int menuo = rnd.Next(1, 13);
            int diena = rnd.Next(1, 31);
            string saskaita = string.Format("NR_{0}_{1}_{2}_01", metai, menuo, diena);
            return saskaita;
        }
        public Saskaita(string gavejas, string siuntejas, int moketiViso, string saskaitosNumeris)
        {
            _gavejas = gavejas;
            _siuntejas = siuntejas;
            _moketiViso = moketiViso;
            _saskaitosNumeris = saskaitosNumeris;

        }
    }
}
