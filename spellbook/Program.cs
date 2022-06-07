using System;
using System.Collections.Generic;
using spellbook;

namespace spellbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generátor náhodných spellů :D");

            List<spell> seznamSpellu = new List<spell>();
            helperClass pomocneMetody = new helperClass();

            string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
            string[] poleTypy = pomocneMetody.PoleZTextu("txt/spelltypes.txt");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Vygenerovat nový spell a přidat do Spellbooku");
                Console.WriteLine("2. Zobrazit Spellbook");
                Console.WriteLine("3. Smazat poslední záznam ve Spellbooku");
                Console.WriteLine("4. Smazat celý Spellbook");
                Console.WriteLine("*. Ukončit program");
                Console.ResetColor();
                string input = Console.ReadLine();

                try
                {
                    if (input == "1")
                    {
                        spell kouzlo = new spell();
                        kouzlo.name = pomocneMetody.vygenerujSpellName(poleForma, poleTypy);
                        kouzlo.manaCost = pomocneMetody.vygenerujCislo(100);
                        seznamSpellu.Add(kouzlo);
                    }
                    else if (input == "2")
                    {
                        foreach (spell urMom in seznamSpellu)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(urMom.name);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine(urMom.manaCost);
                            Console.ResetColor();
                        }
                    }
                    else if (input == "3")
                    {
                        if (seznamSpellu.Count > 0)
                        {
                            int indexSpellu = seznamSpellu.Count - 1;
                            seznamSpellu.RemoveAt(indexSpellu);
                        }
                        else if (seznamSpellu.Count <= 0)
                        {
                            Console.WriteLine("Máte prázdný spellbook");
                        }
                    }
                    else if (input == "4")
                    {
                        seznamSpellu.Clear();
                    }
                    else if (input == "*")
                    {
                        Console.WriteLine("Program ukončen :)");
                        break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}