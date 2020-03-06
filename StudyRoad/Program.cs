using System;
using System.Collections.Generic;

namespace StudyRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Powered by Twilight./Lemon QQ:2728578956");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ENTER TO NEXT");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Happy();
            Console.ForegroundColor = ConsoleColor.White;
            X(13);
            Xv2(13);
            int i = 3;
            while (true) { 
                if (Xv2(i) == "STOP")
                    break;
                i += 2;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 运算符
        /// </summary>
        static void Happy() 
        { 
        // 0为false  1为true
            //----与-并且------------&&-&-----------------------

            int a = 60;            /* 60 = 0 0 1 1    1 1 0 0 */
            int b = 13;            /* 13 =  0 0 0 0   1 1 0 1 */
            int c;                           //  ↓ ↓ ↓ ↓    ↓ ↓ ↓ ↓
                                              //  0 0 0 0    1 1 0 0
            c = a & b;                 /* 12 = 0000 1100 */

            //    false && false => false
            //    false && true => false
            //    true && true  => true
            // 满足 两者都为true 才返回true
            Console.WriteLine("Line 1 - c 的值是 {0}", c);

            //----或--------------------||-|---------------------

                                        /* 60 = 0 0 1 1    1 1 0 0 */
                                        /* 13 =  0 0 0 0   1 1 0 1 */
                                               //  ↓ ↓ ↓ ↓    ↓ ↓ ↓ ↓
                                             //    0 0 1 1    1 1 0 1
            c = a | b;                 /* 61 = 0011 1101 */

            //    false && false => false
            //    false && true  => true
            // 满足 两者中 一个为true 就返回true
            Console.WriteLine("Line 2 - c 的值是 {0}", c);

            //----异或--------^----------------------------------
                                        /* 60 = 0 0 1 1    1 1 0 0 */
                                        /* 13 =  0 0 0 0   1 1 0 1 */
                                               //  ↓ ↓ ↓ ↓    ↓ ↓ ↓ ↓
                                             //    0 0 1 1    0 0 0 1
            c = a ^ b;               /* 49 = 0 0 1 1    0 0 0 1 */

            // true ^ true => false
            // true ^ false => true
            // false ^ false => false
            //满足 两者中 只有唯一一个是true 才返回true
            Console.WriteLine("Line 3 - c 的值是 {0}", c);

            //----反转--------------~----------------------------
                             /* 60 = 0 0 1 1    1 1 0 0 */
                                    //  ↓ ↓ ↓ ↓    ↓ ↓ ↓ ↓
                                  //    1 1 0 0    0 0 1 1
            c = ~a;               /*-61 = 1100 0011 */
            // !true=false   <=>  ~1=-2
            //!false=true    <=>  ~0=-1
            //反转 相当于! 将0变为1 将1变为0 同时会反转正负号
            Console.WriteLine("Line 4 - c 的值是 {0}", c);

            //----移位---------------<<和>>-----------------------
                             /* 60 = 0 0 1 1    1 1 0 0 */
                                    //  向左移动2位
                                  //    1 1 1 1    0 0 0 0
            c = a << 2;     /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - c 的值是 {0}", c);
                             /* 60 = 0 0 1 1    1 1 0 0 */
                                    //  向右移动2位
                                  //    0 0 0 0    1 1 1 1
            c = a >> 2;     /* 15 = 0000 1111 */
            //整体向左/右 移动 箭头方向为移动的方向
            //保持个数不变 前面的位数被丢弃 后面的个数补齐为0
            Console.WriteLine("Line 6 - c 的值是 {0}", c);
            Console.ReadLine();
        }
        /// <summary>
        /// 绘制一个 X
        /// </summary>
        /// <param name="size">大小 必须是奇数</param>
        static void X(int size)
        {
            List<string> data = new List<string>();
            for (int a = 0; a < size; a++)
            {
                List<char> result = new List<char>();
                for (int i = 0; i < size; i++)
                {
                    result.Add('.');
                }
                result[a] = '0';
                result[size-1 - a] = '0';
                data.Add(string.Join("", result));
            }
            Console.WriteLine(string.Join("\r\n", data));
            Console.ReadLine();
        }
        /// <summary>
        /// 绘制一个 X   版本2
        /// </summary>
        /// <param name="size">大小 必须是奇数</param>
        static string Xv2(int size) 
        {
            for (int x = 0; x < size; x++) 
            {
                for (int y = 0; y < size; y++) 
                {
                    if (x == y || x + y == size-1)
                        Console.Write("0");
                    else Console.Write(".");
                }
                Console.WriteLine();
            }
            return Console.ReadLine();
        }
    }
}
