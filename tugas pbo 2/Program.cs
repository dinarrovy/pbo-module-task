using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;

class Laptop
{
    public string merek;
    public string tipe;
    public Vga vga;
    public Processor processor;
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merek} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merek} {tipe} mati");
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Asus : Laptop
{
    public Asus()
    {
        merek = "Asus";
    }
}
class Rog : Asus
{
    public Rog()
    {
        tipe = "ROG";
    }
}
class Vivobook :Asus
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {
        
    }
}
class Acer : Laptop
{
    public Acer()
    {
        merek = "Acer";
    }
}

class Swift : Acer
{
    public Swift()
    {
        tipe = "Swift";
    }
}
class Predator :Acer
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merek} {tipe} sedang bermain game");
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        merek = "Lenovo";
    }
}
class Ideapad : Lenovo
{
    public Ideapad()
    {
        tipe = "Ideapad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}


class Processor
{
    public string merek;
    public string tipe;
}
class Intel : Processor
{
    public Intel()
    {
        merek = "Intel";
    }
}
class AMD : Processor
{
    public AMD()
    {
        merek = "AMD";
    }
}
class corei3 : Intel
{
    public corei3()
    {
        tipe = "Core i3";
    }
}
class corei5 : Intel
{
    public corei5()
    {
        tipe = "Core i5";
    }
}
class corei7 : Intel
{
    public corei7()
    {
        tipe = "Corei7";
    }
}
class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "Ryzen";
    }
}
class Athlon : AMD
{
    public Athlon()
    {
        tipe = "Athlon";
    }
}


class Vga
{
    public string merek;
}
class Nvidia : Vga
{
    public Nvidia()
    {
        merek = "Nvidia";
    }
}
class Amd : Vga
{
    public Amd()
    {
        merek = "AMD";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new corei5();
        laptop1.Ngoding();

        Console.WriteLine($"Laptop {laptop1.merek} {laptop1.tipe} " +
            $"menggunakan VGA {laptop1.vga.merek} dengan " +
            $"Processor {laptop1.processor.merek} {laptop1.processor.tipe}" );

        Laptop laptop2 = new Ideapad();
        laptop2.vga = new Amd();
        laptop2.processor = new Ryzen();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Predator predator1 = new Predator();
        predator1.vga = new Amd();
        predator1.processor = new corei7();
        predator1.BermainGame();

    }
       
}

