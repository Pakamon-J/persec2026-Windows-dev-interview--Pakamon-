using System;

class Program
{
    static void Main()
    {
        string[] items = { "Mother", "Think", "Worthy", "Apple", "Android" };

        string[] result = AutoComplete("th", items, 2);

        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }

    static string[] AutoComplete(string search, string[] items, int maxResult)
    {
        string[] temp = new string[items.Length];
        int count = 0;

        search = search.ToLower();

        // 1. เก็บคำที่ match
        for (int i = 0; i < items.Length; i++)
        {
            string word = items[i].ToLower();

            if (word.Contains(search))
            {
                temp[count] = items[i];
                count++;
            }
        }

        // 2. เรียงลำดับ (Bubble Sort)
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                int rank1 = GetRank(temp[j], search);
                int rank2 = GetRank(temp[j + 1], search);

                if (rank1 > rank2)
                {
                    string t = temp[j];
                    temp[j] = temp[j + 1];
                    temp[j + 1] = t;
                }
            }
        }

        // 3. ตัดตาม maxResult
        int size = count < maxResult ? count : maxResult;
        string[] result = new string[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }

    // ฟังก์ชันจัดอันดับ
    static int GetRank(string word, string search)
    {
        string w = word.ToLower();

        if (w.StartsWith(search))
            return 1; // ขึ้นต้น

        if (w.EndsWith(search))
            return 3; // ลงท้าย

        return 2; // อยู่กลาง
    }
}