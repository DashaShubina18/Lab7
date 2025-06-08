using Lab5;
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

class Program
{

    static List<Bicycle> bicycles;

    static void PrintBicycles()
    {
        foreach (Bicycle bicycle in bicycles)
        {
            Console.WriteLine($"{bicycle.Model}, {bicycle.Year}, {bicycle.Colour}, {bicycle.Price}," +
         $" {bicycle.FrameLoadCapacity}, {bicycle.Weight}, Used: {bicycle.WasUsed}, Damaged: {bicycle.WasDamaged}");
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        bicycles = new List<Bicycle>();
        try
        {
            using (BinaryReader reader = new BinaryReader(File.Open("bicycles.dat", FileMode.Open)))
            {
                int count = reader.ReadInt32(); 
                for (int i = 0; i < count; i++)
                {
                    Bicycle bicycle = new Bicycle();
                    bicycle.Model = reader.ReadString();
                    bicycle.Year = reader.ReadInt32();
                    bicycle.Colour = reader.ReadString();
                    bicycle.Price = reader.ReadDouble();
                    bicycle.FrameLoadCapacity = reader.ReadInt32();
                    bicycle.Weight = reader.ReadDouble();
                    bicycle.WasUsed = reader.ReadBoolean();
                    bicycle.WasDamaged = reader.ReadBoolean();
                    bicycles.Add(bicycle);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка при читанні файлу: " + ex.Message);
        }

        Console.WriteLine("Несортований перелік велосипедів: {0}", bicycles.Count);
        PrintBicycles();
        bicycles.Sort();
        Console.WriteLine("Сортований перелік велосипедів: {0}", bicycles.Count);
        PrintBicycles();

        Console.WriteLine("Додаємо новий запис: Scott Speedster");
        Bicycle bikeScott = new Bicycle("Scott Speedster", 2020, "Grey", 21000, 105, 10.8, false, false);
        bicycles.Add(bikeScott);
        bicycles.Sort();
        Console.WriteLine("Перелік велосипедів після додавання: {0}", bicycles.Count);
        PrintBicycles();

        Console.WriteLine("Видаляємо останнє значення");
        bicycles.RemoveAt(bicycles.Count - 1);
        Console.WriteLine("Перелік велосипедів після видалення: {0}", bicycles.Count);
        PrintBicycles();

        Console.ReadKey();
    }
}
