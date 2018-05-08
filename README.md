// mnogo bozi

















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
System.Console.WriteLine("Napi6i kolko 6e e duljinata na masiva"); int[] masiv;
 int n = int.Parse(Console.ReadLine());
  masiv = new int[n];
   for(int i=0;i<n;i++) { masiv[i] = int.Parse(Console.ReadLine()); }

   int min_num=masiv[0];
        int counter = 1;
        int max_couter = 1;
        int zapomni = masiv[0];
        int helpme=masiv[0];
        int position=0;
        int max_zapomni =masiv[0]; //nai golymata stoinost
        int position=0;
        for(int i=1;i<masiv.Length-1;i++)
        {
        if(min_num>masiv[i])
            {

                min_num=masiv[i];
                position=i;
            }

        }
        for(int i=0;i<masiv.Length;i++)
        {
            zapomni = masiv[i];
            counter = 1;
            for (int j=i+1;j<masiv.Length;j++)
            {
                if(zapomni<masiv[j])
                {
                    if (zapomni < masiv[j] && helpme >= masiv[j])
                    {
                        zapomni = masiv[j];
                        counter++;
                        //helpme = masiv[j];
                    }
                    else if (zapomni < masiv[j])
                        counter++;

                    helpme = masiv[j];

                    if(max_couter<counter)
                    {
                        counter++;
                        max_couter = counter;
                        max_zapomni = masiv[j];
                        position = j;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

        }
        int[] masiv2=new int [max_couter];
        System.Console.WriteLine("{0} {1}",max_couter,max_zapomni);
      /*
        for (int i = 0; i < masiv.Length; i++)
        {
            for (int j = i + 1; j < masiv.Length; j++)
            {
                zapomni = masiv[i];
                if (zapomni< masiv[j])
                {
                    zapomni = masiv[j];
                    counter++;

                    if (max_couter == counter)
                    {


                        int count = 0;
                        for(int p=i;p<masiv.Length;p++)
                        {
                            for(int end=position;end!=p;end--)
                            {
                                if (masiv[position]>masiv[end])
                                {
                                    masiv2[count]= masiv[position];
                                    count++;

                                }
                            }
                        }
                    }
                }
                else
                {
                    counter=1;
                }
            }

            counter = 1;
        }
