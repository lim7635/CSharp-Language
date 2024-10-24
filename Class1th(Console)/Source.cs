// 이미 만들어진 클래스 namespace(System)
using System;

// 임의로 만든 클래스 namespace(Test)
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 콘솔(Console)
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            #endregion

            #region 자료형
            //bool a = true;
            //int b = 10;
            //float c = 3.4f;
            //char d = 'a';

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            #endregion

            #region 조건문
            //int num = 0;

            //if (num > 0) Console.WriteLine("양수");
            //else if (num < 0) Console.WriteLine("음수");
            //else Console.WriteLine("0");
            #endregion

            #region 반복문
            //for (int i = 1; i < 11; i++) Console.WriteLine(i);

            //int j = 1;
            //while(j < 11)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //    //Console.WriteLine(j++)으로 하여도 동일
            //}

            //int k = 1;
            //while(true)
            //{
            //    Console.WriteLine(k++);

            //    if (k > 10) break;
            //}
            #endregion

            #region 연산자(산술, 증감, 관계, 논리)
            //int result, num1, num2;

            //result = 3 + 1;
            //Console.WriteLine(result); // 4

            //result = 3 - 1;
            //Console.WriteLine(result); // 2

            //num1 = 2;
            //result = 5 * num1;
            //Console.WriteLine(result); // 10

            //num2 = 10;
            //result = num2 / 3;
            //Console.WriteLine(result); // 3

            //result = 10 % 2;
            //Console.WriteLine(result); // 0

            //int num = 0;
            //Console.WriteLine(num++); // 0
            //Console.WriteLine(num); // 1
            //Console.WriteLine(--num); // 0
            //Console.WriteLine(num); // 0

            //bool result;
            //int num1, num2;

            //num1 = 3;
            //num2 = 5;

            //result = num1 > num2;
            //Console.WriteLine(result); // false

            //result = num1 < num2;
            //Console.WriteLine(result); // true

            //result = num1 >= num2;
            //Console.WriteLine(result); // false

            //result = num1 <= num2;
            //Console.WriteLine(result); // true

            //result = num1 == num2;
            //Console.WriteLine(result); // false

            //result = num1 != num2;
            //Console.WriteLine(result); // true

            //bool A, B;

            //A = true;
            //B = false;

            //// and
            //Console.WriteLine(A && A); // true
            //Console.WriteLine(A && B); // false

            //// or
            //Console.WriteLine(A || A); // true
            //Console.WriteLine(A || B); // true
            //Console.WriteLine(B || B); // false

            //// not
            //Console.WriteLine(!A); // false
            //Console.WriteLine(!B); // true
            #endregion

            #region 배열
            //// 배열 초기화 방법 첫 번째
            //int[] array1 = new int[3];
            //array1[0] = 1;
            //array1[1] = 2;
            //array1[2] = 3;

            //// 배열 초기화 방법 두 번째
            //int[] array2 = new int[] { 4, 5, 6 };

            //// 배열 초기화 방법 세 번째
            //int[] array3 = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(array1[0]);
            //Console.WriteLine(array1[1]);
            //Console.WriteLine(array1[2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(array2[i]);
            //}

            //Console.WriteLine(array3.Length);

            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.WriteLine(array3[i]);
            //}

            //int[] array4 = { 10, 20, 30 };
            //foreach (int i in array4)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
        }
    }
}