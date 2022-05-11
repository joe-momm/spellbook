using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using spellbook;

namespace spellbook
{
    class helperClass
    {
        public Random generator = new Random();
        public int vyberCislo = Convert.ToInt32(Console.ReadLine());

        public string[] PoleZTextu (string adresaSoubru)
        {
            string adresaTxtSouboru = "spelly/spelly.txt";
            string obsahTXT = File.ReadAllText(adresaTxtSouboru);
        }
        public string vygenerujSpellName (string[] poleForma, string[] poleTypy)
        {
            
        }
        public int vygenerujCislo (int max)
        {
            int generaceCisla = generator.Next(0, vyberCislo);
        }
    }
}
