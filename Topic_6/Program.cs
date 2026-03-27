using System;

class Program
{
    static void Main()
    {
        int[] result1 = Tribonacci(new int[] { 1, 3, 5 }, 5);
        Print(result1);

        int[] result2 = Tribonacci(new int[] { 2, 2, 2 }, 3);
        Print(result2);

        int[] result3 = Tribonacci(new int[] { 10, 10, 10 }, 4);
        Print(result3);
    }

    static int[] Tribonacci(int[] start, int n)
    {
        // ถ้า n = 0 → return ว่าง
        if (n == 0)
            return new int[0];

        int[] result = new int[n];

        // copy ค่าเริ่มต้น
        int len = start.Length;

        for (int i = 0; i < n && i < len; i++)
        {
            result[i] = start[i];
        }

        // ถ้ามีครบ 3 ตัว → เริ่มคำนวณ
        for (int i = len; i < n; i++)
        {
            int a = result[i - 1];
            int b = result[i - 2];
            int c = result[i - 3];

            result[i] = a + b + c;
        }

        return result;
    }

    static void Print(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}