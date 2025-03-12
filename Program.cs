// See https://aka.ms/new-console-template for more information

using modul4_103022300142;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan nama produk: ");
        string namaProduk = Console.ReadLine();
        string kodeProduk = KodeProduk.GetKodeProduk(namaProduk);
        Console.WriteLine(kodeProduk);
        // commit 2
        FanLaptop fanLaptop = new FanLaptop();
        fanLaptop.setState(FanLaptop.State.Balanced);
    }
}