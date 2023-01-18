using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1/CallofTask1
            //var checkmin = Showmin();
            //Console.WriteLine(checkmin);

            //2/CallofTask2
            //var result = Findcount("salam123", '3');
            //Console.WriteLine(result);

            //3/CallofTask3
            //var check = Hasanum("lastday");
            //Console.WriteLine(check);

            //4/ CallofTask5
            //var result = Showindex(22);
            //Console.WriteLine(result);



        }



        #region Task1+ Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
        //static int Showmin()
        //{
        //    int[] numbers = { 22, 45, 2, 20, 6 };
        //    int min = numbers[0];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < min)
        //        {
        //            min = numbers[i];
        //        }
        //    }
        //    return min;


        //}

        #endregion

        #region Task2+ Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod

        //static int Findcount(string str, char cr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == cr)
        //        {
        //            count++;

        //        }

        //    }
        //    return count;
        //}

        #endregion

        #region Task3+ Verilmiş yazıda rəqəm olub olmadığını tapan metod  
        //static bool Hasanum(string word)
        //{
        //    char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = 0; j < word.Length; j++)
        //        {
        //            if (word[j] == nums[i])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        #endregion

        #region Task4- Verilmiş yazını əksinə çevirən metod (misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)
        // Yaza bilmedim...
        #endregion

        #region Task5+  - Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.
        //static int Showindex(int num)
        //{
        //    int[] numbers = { 22, 24, 454, 656, 867 };
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == num)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        #endregion





    }
}

