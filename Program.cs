using System;
class Bai7
{
    static void Main(string[] args)
    {
        //Opening
        Console.WriteLine($"Hello!");

        //Nhap so nam
        Console.WriteLine($"Nam: ");
        int nam  = int.Parse(Console.ReadLine()!);

        //Kiem tra nam nhuan va in ra destop
        if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
        {
            Console.WriteLine($"{nam} la nam nhuan");
        }
        else
        {
            Console.WriteLine($"{nam} khong phai nam nhuan");
        }
    }
}