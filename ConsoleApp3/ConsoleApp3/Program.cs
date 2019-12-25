using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //public delegate bool Check(int n);
        //public delegate void ConCat(string s1, string s2);

        //public delegate void Check(int n);
        static void Main(string[] args)
        {
            #region delegate
            //Console.WriteLine(Sum(new int[] { 21, 12, 33, 2, 5 }, isEven));
            //Console.WriteLine(Sum(new int[] { 21, 12, 33, 2, 5 }, isElder));
            //Test(Fullname);

            //Check check = new Check(isElder);
            //Check check = isElder;
            //check += isEven;
            //Console.WriteLine(check(15));

            //Check check = isOdd;
            //check += isElder;
            //check -= isOdd;
            //check.Invoke(15);
            #endregion

            #region Anonim function, lambda expression
            //Check check = delegate (int n)
            //  {
            //      Console.WriteLine(n);
            //  };
            //check += n =>
            //{
            //    Console.WriteLine("lambda expression");
            //};
            //check += isElder;
            //check.Invoke(15);
            //check += isOdd;
            //check(20);

            //ConCat con = (s1, s2) =>Console.WriteLine($"{s1} {s2}");
            //con += Fullname;

            //con("Huseyn", "Yusifov");
            #endregion

            #region Action,Func

            //Action<string, string, int> con = delegate (string s1, string s2, int n)
            // {
            //     Console.WriteLine(s1);
            // };

            //con += Fullname;
            //con += (s1, s2, n) => Console.WriteLine(s2);
            //con -= (s1, s2, n) => Console.WriteLine(s2);

            //con("Kamran", "Jabiyev",29);

            Func<int, bool> func = isElder;
            func += isEven;
            Console.WriteLine(func(20));

            //Func<int, int> func = n => n + 10;
            //func += n => n + 20;

            //Console.WriteLine(func(10));

            #endregion

        }

        static bool isElder(int n)
        {
            return n > 20;
        }
        static bool isEven(int n)
        {
            return n % 2 == 0;
        }

        static void Fullname(string name, string surname,int age)
        {
            Console.WriteLine($"{name} {surname} {age}");
        }

        static void isOdd(int n)
        {
            string response = n % 2 != 0 ? "Odd" : "Even";
            Console.WriteLine($"{n} is {response}");
        }

        //static void isElder(int n)
        //{
        //    string response = n > 10 ? "Yes" : "No";
        //    Console.WriteLine($"{response}");
        //}

        

        



        //static void Test(ConCat func)
        //{
        //    func("Kamran","Jabiyev");
        //}



        //static int Test(int n1)
        //{
        //    return n1;
        //}


        //static int Sum(int[] arr,Check func)
        //{
        //    int res = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (func(arr[i]))
        //        {
        //            res += arr[i];
        //        }
        //    }

        //    return res;
        //}
    }
}
