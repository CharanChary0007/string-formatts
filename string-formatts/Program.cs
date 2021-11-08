using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace string_formatts
{
  
   
        class stringfor
        {
            static void Main(String[] args)
            {
                ArrayCheak();
                M1();
                String_manuplation();
                String_Compare();
                stringfor obj1 = new stringfor();

                obj1.Index_varable();

            }
            public static void ArrayCheak()
            {
                Console.WriteLine("Enter the size of an array");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the values  of an array");
                int[] ArrayElements = new int[size];
                for (int i = 0; i < size; i++)
                {
                    ArrayElements[i] = Convert.ToInt32(Console.ReadLine());
                }
                Arrycheak obj2 = new Arrycheak();
                obj2.Arraymethods(ArrayElements, size);

            }





            //string a = "hi am chaarabn";
            private static void M1()
            {
                var a = 55;
                var c = 99;
                var x = 51;
                var v = 91;
                var f = 5;
                var e = 9;
                var TodayDAte = DateTime.Now;
                string b = String.Format("todays date is {0:d} {1} {2}  ", TodayDAte, c, a, x, v, f, e); Console.WriteLine(b);
                string name = "iam charan and iam called as TEJA";
                Console.WriteLine(name.ToUpper());
                Console.WriteLine(name.ToLower());
                Console.WriteLine(char.ToUpper(name[0]) + name.Substring(1));
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] != ' ')
                    {

                        Console.Write(name[i]);
                    }
                }


            }
            private static void String_manuplation()
            {
                string b = "abc";
                Console.WriteLine(b.PadLeft(10, '0'));
                bool b1;
                string g = "iam the one and only charan";
                b1 = g.StartsWith("iam");
                bool b2 = g.EndsWith("charan");
                bool b3 = g.Contains("one");
                string name = "charan";
                string namee = "one";
                Console.WriteLine($"the letter starts with\"iam\": {b1}");
                Console.WriteLine("the letter ends with \"{0}\"; {1}", name, b2);
                Console.WriteLine("the letter contains  \"{0}\"; {1}", namee, b3);
            }
            private static void String_Compare()
            {
                string a = "dad";
                string b = "Dad";
                bool b1 = string.Equals(a, b);
                if (b1 == true)
                {
                    Console.WriteLine("eaques");

                }
                else
                {
                    Console.WriteLine("not equal");
                }
            }
            private void Index_varable()
            {
                string nam = "iam the one who never give up but will try till the end";
                string namee = " ";
                namee = nam.Substring(21, nam.Length - 21);
                Console.WriteLine(nam.IndexOf("d"));
                Console.WriteLine(namee);
            }

        }
        class Arrycheak
        {
            public void Arraymethods(int[] ary, int a)
            {
                foreach (int i in ary)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.WriteLine("sorted array");
                Array.Sort(ary);
                foreach (int i in ary)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Array.Reverse(ary);
                Console.WriteLine("Reverse of an array");
                foreach (int i in ary)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Console.WriteLine("{0}  is the minimum value in an \"Array\"", ary.Min());
                Console.WriteLine("{0}  is the maximum value in an \"Array\"", ary.Max());
                Console.WriteLine("{0}  is the sum value in an \"Array\"", ary.Sum());
            }
        }
    }

