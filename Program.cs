using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type a word to see if it is palindrome or not");
        string? word = Console.ReadLine();

        if (word != null && IsPalindrome(word))
        {
            Console.WriteLine($"{word} is a palindrome");
        }
        else
        {
            Console.WriteLine($"{word} is not palindrome");
        }

    }

    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }



}