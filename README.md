using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachki
{
    class Program
    {
        static void Main()
        {
            //единият вариянт за решаване е намиране на най-малкото число след което сравняваш от този ред 
            System.Console.WriteLine("Napi6i kolko 6e e duljinata na masiva");
            int[] masiv;
            int n = int.Parse(Console.ReadLine());
            masiv = new int[n];
            for (int i = 0; i < n; i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());
            }
            int helpme = masiv[0];
            int position=0 ;
            //  int max_zapomni =masiv[]; //nai golymata stoinost
            int min=masiv[0];
            int min_position = 0;
            int proverka = 0;
           
            //Console.Write("{0}", position);
            do
            {
                
                  //  min = masiv[position];
                
                
                //if (position >= n)
                  //  break;
                for (int i = position; i < masiv.Length; i++)
                {
                    if (min > masiv[i])
                    {
                        min = masiv[i];
                        min_position = i;
                        proverka =1;
                    }
                }
                Console.Write("{0} ", min);
                
                // tuka ne6o se naebawa i samo twa ba4ka ???? i do dolu ne stiga 
                if (proverka == 0)
                    break ;

               // if (min_position + 1 >= n)
                 //  break; 
                proverka = 0;
                position = min_position+1;
                Console.Write("{0}", position);
                min = masiv[position];
                //Console.Write("{0}", position);
            } while (true);
                
