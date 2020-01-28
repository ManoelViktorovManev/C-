using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6 zada4ka ot u4ebnika
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
                












//12 zad dowur6i ya d ! 
             int a;//vertikal;
            int b;//horizont;
            //4 ; 0 
            Console.WriteLine("Wuwedi duljinata na matricata");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            int[,] matric = new int[a, b];
            int boza = 0;
            int horizont_zapomni = 0;
            int vertikal_zapomni = -1;
            int ez = 1;
            int zapomni = -1;
            if (b % 2 == 1)
                ez = 1;
            for (int i = 0; i < (b / 2)+ez; i++)
            {
                horizont_zapomni = horizont_zapomni + 1;
                boza = horizont_zapomni;
                //3
                for (int k = a - 1; k >= 0; k--)
                {
                    if (vertikal_zapomni == a - 1)
                        vertikal_zapomni = a - 1;
                    else
                    {
                        vertikal_zapomni++;
                    }
                    if (ez==1)
                    {
                    if (k == (a / 2) + 1 && i==((b/2)+ez)-1)
                                            break;
                    }
                    
                    matric[i, k] = boza + (1 * vertikal_zapomni);
                    
                    boza = matric[i, k];
                }
                zapomni++;
                vertikal_zapomni = zapomni;
            }

            vertikal_zapomni = -1;
            horizont_zapomni = a * b + 1;
            zapomni = -1;
            
            for (int i = b-1; i >= b/2; i--)
            {
                horizont_zapomni = horizont_zapomni - 1;
                boza = horizont_zapomni;
                for (int k = 0; k < a; k++)
                {
                    if (vertikal_zapomni == a - 1)
                        vertikal_zapomni = a - 1;
                    else
                    {
                        vertikal_zapomni++;
                    }
                    matric[i, k] = boza - (1 * vertikal_zapomni);
                    boza = matric[i, k];
                }
                zapomni++;
                vertikal_zapomni = zapomni;

            }
            

            for (int i = 0; i < b; i++)
            {
                Console.Write("\n");
                for (int k = 0; k < a; k++)
                {

                    System.Console.Write("{0}\t", matric[k, i]);

                }


                //Console.Write("\n\n");
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            22 zada4a malko i ima 
             {
 int[] masiv;
            Console.WriteLine("Napi6i duljinata na masiva");
            int size = int.Parse(Console.ReadLine());
            masiv = new int[size];
            for(int i=0;i<size;i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Napi6i duljinata turseniya zbor");
            int sbor = int.Parse(Console.ReadLine());
            Console.WriteLine("Napi6i kolko elementi ni trybwat");
            int elementi = int.Parse(Console.ReadLine());
            int max = masiv[0];
            int zapomni = 0;
            int uweli4i = 0;
            bool stawali = false;
            do
            {
                max = masiv[0];
                for (int i = 0; i < size; i++)
                {
                    if (masiv[i] == sbor)
                    {
                       // Console.WriteLine("{0}", masiv[i]);
                        stawali = true;
                        max=masiv[i];
                        break;
                    }

                    if (masiv[i] <= sbor && masiv[i] > max)
                    {
                        max = masiv[i];
                        zapomni = i;
                    }
                }
                    uweli4i++;
                    sbor = sbor - max;
                    Console.WriteLine("{0}", max);
                    if (sbor == 0 && elementi == uweli4i)
                    {
                        stawali = true;
                        break;
                    }
                    if (sbor == 0 && elementi != uweli4i)
                    {
                        sbor = sbor + max;

                    }
                    
                    masiv[zapomni] = 0;
                
            } while (size>uweli4i);            
            if(stawali==true)
            {
                Console.WriteLine("Wsi4ko e tok i jica");

            }
            else
            {
                Console.WriteLine("Tujno");
            }



25 zada4a
   int chislo;
            Console.WriteLine("Ima6 da wuwede6 chislo");
           chislo= int.Parse(Console.ReadLine());
            bool sre6a_li_se = false;
            int zapomni = 0;
            //formula za kombinaciya e n-4isla => ako sa 3 => 1
            //123 132 213 231 312 321
            //1234 1243 1324 1342 1423 1432 4123 4132 4213 4231 4312 4321 2134 2143 2314 2341 2413 2431 3124 3142 3214 3241 3421 3412
            for(int i=1;i<=chislo;i++)
            {
              
                for(int k=1;k<=chislo;k++)
                {
                    Console.Write("{0}",i);
                    if(k==i)
                        sre6a_li_se = true; 
                    if(sre6a_li_se==false)
                    {
                        zapomni = k;
                        Console.Write("{0}",k);
                        for(int j=1;j<=chislo;j++)
                        {
                            if(j!=i&&j!=k)
                            {
                                Console.Write("{0} ", j);

                            }
                        }
                        
                        
                    }
                        
                    sre6a_li_se = false;
                    
                }
                Console.WriteLine();
                
            }
