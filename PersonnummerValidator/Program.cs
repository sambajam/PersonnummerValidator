using System;
using System.Text.RegularExpressions;

public class Program
{
    static void Main()
    {
        Console.Write("Ange ett svenskt personnummer (ÅÅMMDD-XXXX): ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && IsValidSwedishPersonalNumber(input))
            Console.WriteLine("\u2705 Personnumret är giltigt!");
        else
            Console.WriteLine("\u274C Ogiltigt personnummer!");
    }

    public static bool IsValidSwedishPersonalNumber(string pnr)
    {
        if (string.IsNullOrEmpty(pnr) || !Regex.IsMatch(pnr, @"^\d{6}-\d{4}$"))
            return false;

        pnr = pnr.Replace("-", "");
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            int num = (pnr[i] - '0') * (i % 2 == 0 ? 2 : 1);
            sum += num > 9 ? num - 9 : num;
        }
        int checkDigit = (10 - (sum % 10)) % 10;

        return checkDigit == (pnr[9] - '0');
    }
}