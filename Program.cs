using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Enter a whole number from -99999-99999");
            try
            {
                int x = int.Parse(Console.ReadLine());
                string add = "";
                string num = "Your number is ";
                bool t = false;
                bool f = true;
                bool d = false;
                if (x == 0)
                    num += "zero";
                if (x < 0)
                {
                    num += "Negative ";
                    x = Math.Abs(x);
                }
                if (x > 99999)
                    Console.WriteLine("That is way to big!!! Try again.");
                else
                {
                    if ((x / 10000) > 0)
                    {
                        t = true;
                        add = Tens(x / 10000);
                        if (add.Equals("teen"))
                        {
                            f = false;
                            t = false;
                            add = Teens(x / 1000);
                        }
                        num += add;
                    }
                    if (t)
                    {
                        if (((x / 1000) % 10) > 0 && f)
                            add = "-" + Number(((x / 1000) % 10));
                        num += add + " Thousand ";
                        t = true;
                    }
                    if (((x / 1000) > 0) && !t && f)
                    {
                        add = Number(x / 1000);
                        num += add + " Thousand ";
                        t = true;
                    }
                    if (!f)
                    {
                        num += " Thousand ";
                        f = true;
                    }
                    if (((x / 100) % 10) > 0)
                    {
                        add = Number((x / 100) % 10);
                        num += add + " Hundred ";
                        t = true;
                    }
                    else if (x % 100 > 0 && x / 1000 > 0)
                        num += "and ";
                    if (((x / 10) % 10) > 0)
                    {
                        t = true;
                        d = true;
                        add = Tens((x / 10) % 10);
                        if (add.Equals("teen"))
                        {
                            f = false;
                            add = Teens(x % 100);
                        }
                        num += add;
                    }
                    if (((x / 10) % 10) > 0 && !t)
                    {
                        t = true;
                        d = true;
                        add = Tens(x % 10);
                        if (add.Equals("teen"))
                        {
                            f = false;
                            add = Teens(x % 100);
                        }
                        num += add;
                    }
                    if (t && f && d)
                        num += "-";
                    if (x % 10 > 0 && f)
                    {
                        add = Number(x % 10);
                        num += add;
                    }
                    Console.WriteLine(num);
                    loop = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("That is not a whole number!!! Also you didn't break my code so try again!!!");
            }
        }
    }
    public static string Number(int y)
    {
        if (y == 1)
            return "One";
        if (y == 2)
            return "Two";
        if (y == 3)
            return "Three";
        if (y == 4)
            return "Four";
        if (y == 5)
            return "Five";
        if (y == 6)
            return "Six";
        if (y == 7)
            return "Seven";
        if (y == 8)
            return "Eight";
        if (y == 9)
            return "Nine";
        else
            return "problem";
    }
    public static string Tens(int y)
    {
        if (y == 1)
            return "teen";
        if (y == 2)
            return "Twenty";
        if (y == 3)
            return "Thirty";
        if (y == 4)
            return "Forty";
        if (y == 5)
            return "Fifty";
        if (y == 6)
            return "Sixty";
        if (y == 7)
            return "Seventy";
        if (y == 8)
            return "Eighty";
        if (y == 9)
            return "Ninety";
        return "problem";
    }
    public static string Teens(int y)
    {
        if (y == 10)
            return "Ten";
        if (y == 11)
            return "Eleven";
        if (y == 12)
            return "Twelve";
        if (y == 13)
            return "Thirteen";
        if (y == 14)
            return "Fourteen";
        if (y == 15)
            return "Fifteen";
        if (y == 16)
            return "Sixteen";
        if (y == 17)
            return "Seventeen";
        if (y == 18)
            return "Eighteen";
        if (y == 19)
            return "Nineteen";
        return "problem";
    }
}