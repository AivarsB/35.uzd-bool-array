using System;

namespace _35.uzd_bool_array
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] values = new bool[] { true, false, true, true, true, true, true, true, true };

            bool result = true;

            foreach (var value in values)
            {
                if (value == false)
                {
                    result = false;
                    break;
                }
            }

            if (result == true)
            {
                Console.WriteLine("All crosses are ok");
            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == false)
                    {
                        Console.WriteLine($"Cross {i} is not ok");
                    }
                }
            }
        }
    }
}
// Definēt bool tipa masīvu ar 10 elementiem, kur katra vērtība atbilst vienam krustojumam. 
// Programmai ir jānosaka, vai var izbraukt cauri visiem krustojumiem. 
// Ja visus krustojumus izbraukt nevar, ir jāizdrukā, kuram krustojumam netiek cauri.