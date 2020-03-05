using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static async Task Main(string[] args)

        {
            try
            {
                var url = args.Length > 0 ? args[0] : "https://www.pja.edu.pl";

                // if (args.Length == 0) return;

                var client = new HttpClient();
                var result = await client.GetAsync("Https://www.pja.edu.pl");

                if (!result.IsSuccessStatusCode)
                {
                    Console.WriteLine("server errror");
                    return;
                }
                string html = await result.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z.]+");
                var matches = regex.Matches(html);

                //Kolekcje
                var set = new HashSet<string>();
                //LINQ
                var list = new List<string>();
                //
                //LINQ
                var elementy = from e in list
                               where e.StartsWith("A")
                               select e;
                //
                var elementy2 = list.Where(s => s.StartsWith("A"));

                var slownik = new Dictionary<string, string>();

                foreach (var m in matches)
                {
                    Console.WriteLine(m);
                }
            }catch(Exception exc)
            {
               // string.Format("Wystapil blad {0}", exc.ToString());
                Console.WriteLine($"Wystapil blad {exc.ToString()}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}

