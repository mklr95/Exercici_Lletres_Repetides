using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasRepetidas
{
    class Program
    {
        const String nombre = "Marc";
        const String apellido1 = "Llobera";
        const String apellido2 = "Rodríguez";
        const String nombreCombinado = nombre + apellido1 + apellido2;
        static void Main(string[] args)
        {
            char[] chars = nombreCombinado.ToCharArray();
            foreach (char item in chars)
            {
                Console.WriteLine("{0}", item);
            }

            List<char> lists = chars.OfType<char>().ToList();
            foreach (char item in lists)
            {
                if (Char.IsNumber(item))
                {
                    Console.WriteLine("LOS NOMBRES DE PERSONAS NO CONTIENEN NUMEROS!! {0}", item);
                }
                else
                {
                    if (item.Equals('A') || item.Equals('E') || item.Equals('I') || item.Equals('O') || item.Equals('U') || item.Equals('á') || item.Equals('é') || item.Equals('í') || item.Equals('ó') || item.Equals('ú') || item.Equals('Á') || item.Equals('É') || item.Equals('Ó') || item.Equals('Ó') || item.Equals('Ú') || item.Equals('a') || item.Equals('e') || item.Equals('i') || item.Equals('o') || item.Equals('u'))
                    {
                        Console.WriteLine("VOCAL {0}", item);
                    }
                    else
                    {
                        Console.WriteLine("CONSONANTE {0}", item);
                    }
                }

            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("NOMBRE");
            Dictionary<char, int> dicionarionombre = Count(nombre);
            printDictionary(dicionarionombre);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("APELLIDOS");
            Dictionary<char, int> dicionarioapellido = Count(apellido1+apellido2);
            printDictionary(dicionarioapellido);
        }

        public static Dictionary<char, int> Count(string stringToCount)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in stringToCount)
            {
                int counter = 0;
                characterCount.TryGetValue(character, out counter);
                characterCount[character] = counter + 1;
            }

            return characterCount;
        }

        public static void printDictionary(Dictionary<char, int> picTionary)
        {
            foreach (KeyValuePair<char, int> kvp in picTionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
