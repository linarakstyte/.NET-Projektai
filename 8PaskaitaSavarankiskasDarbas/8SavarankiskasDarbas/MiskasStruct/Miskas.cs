using System;
using System.Collections.Generic;

namespace MiskasStruct
{
    public struct Miskas
    {
        public List<int> medziai;

        public void Medis()
        {
            medziai = new List<int>();
        }
        public void PasodintiMedi()
        {
            medziai.Add(1);
        
        }
    }
}
