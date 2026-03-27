using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(Check("()"));
        Console.WriteLine(Check("([)]"));
        Console.WriteLine(Check("({})"));
        Console.WriteLine(Check("(({}))]"));
        Console.WriteLine(Check(")"));
        Console.WriteLine(Check("{"));
    }

    static bool Check(string text)
    {
        Stack<char> box = new Stack<char>(); // เก็บวงเล็บที่เปิด

        foreach (char c in text)
        {
            // ถ้าเป็นวงเล็บเปิด → เก็บไว้
            if (c == '(' || c == '[' || c == '{')
            {
                box.Push(c);
            }
            else // ถ้าเป็นวงเล็บปิด
            {
                // ถ้ายังไม่มีตัวเปิดเลย → ผิดทันที
                if (box.Count == 0)
                    return false;

                char last = box.Pop(); // เอาตัวล่าสุดออก

                // เช็คว่าปิดถูกคู่ไหม
                if (c == ')' && last != '(') return false;
                if (c == ']' && last != '[') return false;
                if (c == '}' && last != '{') return false;
            }
        }

        // ถ้ายังมีค้างอยู่ แปลว่าเปิดแล้วไม่ปิด
        if (box.Count != 0)
            return false;

        return true;
    }
}