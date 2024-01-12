using System;
using System.ComponentModel.Design;

namespace övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Välj räknings sätt");
                Console.WriteLine("X");
                Console.WriteLine("-");
                Console.WriteLine("+");
                Console.WriteLine("/");
                string räk = Console.ReadLine();
                if (räk == "x")
                {
                    Console.WriteLine("skriv in ett tal");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in ett till tal");
                    int tal2 = int.Parse(Console.ReadLine());
                    int resultat = tal1 * tal2;
                    Console.WriteLine(tal1 + " x " + tal2 + " = " + resultat);
                    Console.WriteLine("om du vill stänga appen skriv S eller om du vill fortsätta tryck på enter");
                    string S = Console.ReadLine();
                    if (S == "S")
                    {
                        Console.WriteLine("Hejdå");
                        break;
                    }
                }
                if (räk == "-")
                {
                    Console.WriteLine("skriv in ett tal");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in ett till tal");
                    int tal2 = int.Parse(Console.ReadLine());
                    if (tal1 > tal2)
                    {
                        int resultat = tal1 - tal2;
                        Console.WriteLine(tal1 + " - " + tal2 + " = " + resultat);
                        Console.WriteLine("Om du vill stänga programmet tryck på S eller om du vill fortsätta tryck på enter");
                        string S = Console.ReadLine();
                        if (S == "S")
                        {
                            Console.WriteLine("hejdå");
                            break;
                        }
                    }
                    if (tal1 < tal2)
                    {
                        int resultat = tal2 - tal1;
                        Console.WriteLine(tal2 + " - " + tal1  + " = " + resultat);
                        Console.WriteLine("Om du vill stänga programmet tryck på S eller om du vill fortsätta tryck på enter");
                        string S = Console.ReadLine();
                        if (S == "S")
                        {
                            Console.WriteLine("hejdå");
                            break;
                        }
                    }
                }
                if (räk == "+")
                {
                    Console.WriteLine("skriv in ett tal");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in ett till tal");
                    int tal2 = int.Parse(Console.ReadLine());
                    int resultat = tal1 + tal2;
                    Console.WriteLine(tal1 + " + " + tal2 + " = " + resultat);
                    Console.WriteLine("om du vill stänga appen skriv S eller om du vill fortsätta tryck på enter");
                    string S = Console.ReadLine();
                    if(S == "S")
                    {
                        Console.WriteLine("Hejdå");
                        break;
                    }
                }
                if (räk == "/")
                {
                    Console.WriteLine("skriv in ett tal.");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in ett till tal");
                    int tal2 = int.Parse(Console.ReadLine());
                    int resultat = tal1 / tal2;
                    Console.WriteLine(tal1 + " / " + tal2 + " = " + resultat);
                    Console.WriteLine(" om du vill stänga skriv S eller om du vill fortsätta tryck på enter");
                    string S = Console.ReadLine();
                    if (S == "S")
                    {
                        Console.WriteLine("Hejdå..");
                        break;


                    }
                }
            }
        }
    }
}

