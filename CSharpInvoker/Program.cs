using System;
using System.Runtime.InteropServices;

namespace CSharpInvoker
{
    class Program
    {
        [DllImport("PInvoke_Test.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, PreserveSig = true, SetLastError = false)]
        private static extern int add(int x, int y);

        [DllImport("PInvoke_Test.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, PreserveSig = true, SetLastError = false)]
        private static extern int sub(int x, int y);

        [DllImport("PInvoke_Test.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, PreserveSig = true, SetLastError = false)]
        private static extern int add_array(int[] x, int len);

        [DllImport("PInvoke_Test.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, PreserveSig = true, SetLastError = false)]
        private static extern int sub_array(int[] x, int len);

        static void Main(string[] args)
        {
            Console.WriteLine("CSharp Invoker started...");

            int[] add_params = new int[4] { 0, 1, 2, 3 }; // 6
            int[] sub_params = new int[4] { 4, 5, 6, 7 }; // -14

            Console.WriteLine($"2+2: {add(2, 2)}");
            Console.WriteLine($"3-4: {sub(3, 4)}");
            Console.WriteLine($"0+1+2+3: {add_array(add_params, add_params.Length)}");
            Console.WriteLine($"4-5-6-7: {sub_array(sub_params, sub_params.Length)}");

            Console.WriteLine("CSharp Invoker terminated");
        }
    }
}
