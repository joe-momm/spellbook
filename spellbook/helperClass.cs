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

        public string[] PoleZTextu (string adresaSouboru)
        {
            string obsahTXT = File.ReadAllText(adresaSouboru);
            string[] oddeleny = obsahTXT.Split(";") ;
            return oddeleny;
        }
        public string vygenerujSpellName (string[] poleForma, string[] poleTypy) 
        {
            string spellName = "";
            string forma = poleForma[vygenerujCislo(poleForma.Length - 1)];
            string typ = poleTypy[vygenerujCislo(poleTypy.Length - 1)];
            spellName = typ + " " + forma;
            return spellName;
        }
        public int vygenerujCislo (int max)
        {
            int generaceCisla = generator.Next(0, max);
            return generaceCisla;
        }
    }
}
