using System.Text;

namespace Ass_4
{
    internal class Program
    {
        /*#region fun Swich
        static void Swich(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Swich(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        } 
        #endregion*/

        /* #region getSum fun
         static void getSum(int[] nums)
         {
             int sum = 0;
             nums = new int[] { 5, 6, 7, 8 };
             for (int i = 0; i < nums.Length; i++)
             {
                 sum += nums[i];
             }
         }
         static void getSum(ref int[] nums)
         {
             int sum = 0;
             nums = new int[] { 5, 6, 7, 8 };
             for (int i = 0; i < nums.Length; i++)
             {
                 sum += nums[i];
             }
         } 
         #endregion*/

        /*#region fun cal
        static void cal(int x, int y, out int sum, out int substrac)
        {
            sum = x + y;
            substrac = x - y;
        } 
        #endregion*/

        /*#region getsumind
        static int getSumIndiv(int n)
        {
            int sum = 0;
            int digit = 0;
            while (n > 0)
            {
                digit = n % 10;
                sum += digit;
                n /= 10;

            }
            return sum;
        } 
        #endregion*/

        /* #region is prime
         static bool IsPrime(int num)
         {
             for (int i = 2; i < Math.Sqrt(num); i++)
             {
                 if (num % i != 0)
                     return false;
             }
             return true;
         } 
         #endregion*/

        /*#region MinMaxArray
        static void MinMaxArray(ref int[] array, ref int min, ref int max)
        {
            max = array[0];
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
        } 
        #endregion*/

        /*#region fact
        static int fact(int x)
        {
            int sum = 1;
            for (int i = 1; i <= x; i++)
            {
                sum *= i;
            }
            return sum;
        } 
        #endregion*/

/*        #region ChangeChar
        static StringBuilder ChangeChar(ref StringBuilder text, int start, char c)
        {
            text.Remove(start - 1, 1);
            text.Append(c);
            return text;
        } 
        #endregion*/
        static void Main(string[] args)
        {
            /*#region Q1
            //passing by value: بيبعت القيم بتاعت المتغير بحيث اننا لو عدلنا عليها مش هيتعدل ف المتغير الاصلي
            int num1 = 1;
            int num2 = 2;
            Swich(num1, num2);
            Console.WriteLine($"num1 = {num1} num2 = {num2}");
            //passing by reference: بيبعت الأدريس بتاع المتغير ك براميتر بحيث اننا لو غيرنا ف القيمه هيتغير ف المتغير الاصلي كمان بعد ما نخرج بره الفانكش
            Swich(ref num1, ref num2);
            Console.WriteLine($"num1 = {num1} num2 = {num2}"); 
            #endregion*/

            /* #region Q2
             //(Reference type parameters) by value: لما بنبعت اراي ع سبيل المثال بيتم تدمير الاراي القديم وبيتعمل اراي جديد بيتحط فيه العناصر اللى كانت ف الاراي القديم ويتم تعديل عليها 
             //(Reference type parameters) by Reference: بيتم تغيير اسم الاراي بالاسم اللى احنا بعتناه وبيتم كل تعديلات بتحصل فيها بعد كده لما بنعمل ريتيرن بيرجع اسم الاراي تاني ومش بيبان الاختلاف حتي لو غيرت ف الاوبجكت ع عكس اللى قبله
             int[] arr = new int[] { 1, 2, 3, 4 };
             getSum(arr);
             Console.WriteLine(arr[0]);
             getSum(ref arr);
             Console.WriteLine(arr[0]); 
             #endregion*/

            /*#region Q3
            int num1 = 5;
            int num2 = 2;
            int sum = 0;
            int substrac = 0;
            cal(num1, num2, out sum, out substrac);
            Console.WriteLine(sum);
            Console.WriteLine(substrac); 
            #endregion*/

            /*#region Q4
            int m;
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(getSumIndiv(m)); 
            #endregion*/

            /* #region Q5
             int num = 0;
             num = Convert.ToInt16(Console.ReadLine());
             if (IsPrime(num))
             {
                 Console.WriteLine("is prime");
             }
             else { Console.WriteLine("is not prime"); } 
             #endregion*/

            /*#region Q6
		int[] array = { 1, 2, 3, 4, 5 };
            int min=0;
            int max=0;
            MinMaxArray(ref array,ref min ,ref max);
            Console.WriteLine(max);
            Console.WriteLine(min); 
#endregion*/

            /* #region Q7
             int x;
             x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(fact(x)); 
             #endregion*/

            /*#region Q8
            int x;
            char y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToChar(Console.ReadLine());
            StringBuilder te = new StringBuilder("my names mohsen saber");
            ChangeChar(ref te, x, y);
            Console.WriteLine(te.ToString()); 
            #endregion*/
        }
    }
}