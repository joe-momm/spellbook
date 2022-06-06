using System;
using System.Collections.Generic;
using spellbook;

namespace spellbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generátor náhodných spellů");

            List<spell> seznamSpellu = new List<spell>();
            helperClass pomocneMetody = new helperClass();

            string[] poleForma = pomocneMetody.PoleZTextu("text/spellform.txt");
            string[] poleTypy = pomocneMetody.PoleZTextu("text/spelltypes.txt");

            while (true)
            {
                Console.WriteLine("1. Vygenerovat nový spell a přidat do Spellbooku");
                Console.WriteLine("2. Zobrazit Spellbook");
                Console.WriteLine("3. Smazat poslední záznam ve Spellbooku");
                Console.WriteLine("4. Smazat celý Spellbook");
                Console.WriteLine("*. Ukončit program");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    spell kouzlo = new spell();
                    kouzlo.name = pomocneMetody.vygenerujSpellName(poleForma,poleTypy);
                    kouzlo.manaCost = pomocneMetody.vygenerujCislo(100);
                    seznamSpellu.Add(kouzlo);
                }
                else if (input == "2")
                {

                }
                else if (input == "3")
                {
                    
                }
                else if (input == "4")
                {
                    
                }
                else if  (input == "*")
                {
                    
                }
            }
        }
    }
}