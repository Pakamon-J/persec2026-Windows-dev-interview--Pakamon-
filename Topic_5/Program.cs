using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(SortNumber(3008)); // 8300
        Console.WriteLine(SortNumber(1989)); // 9981
        Console.WriteLine(SortNumber(2679)); // 9762
        Console.WriteLine(SortNumber(9163)); // 9631
    }

    static int SortNumber(int num)
    {
        // แปลงเป็น string
        string s = num.ToString();

        // แปลงเป็น array char
        char[] arr = s.ToCharArray();

        // sort จากมาก → น้อย (Bubble Sort)
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    char temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        // รวมกลับเป็น string
        string result = new string(arr);

        // แปลงกลับเป็น int
        return int.Parse(result);
    }
}