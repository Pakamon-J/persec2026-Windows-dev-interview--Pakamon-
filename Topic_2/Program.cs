using System;

public class Program
{
    public static void Main() // 👈 เพิ่มตรงนี้
    {
        string[] arr = { "TH19", "SG20", "TH2" };

        SortData(arr);

        foreach (string s in arr)
        {
            Console.WriteLine(s);
        }
    }

    public static void SortData(string[] data)
    {
        int n = data.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (Compare(data[j], data[j + 1]) > 0)
                {
                    string temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }

    static int Compare(string a, string b)
    {
        return string.Compare(a, b);
    }
}