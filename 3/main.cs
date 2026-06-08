//Works well in online gdb but I had a hard time trying to make it work in VsCode
using System;
using TempApp;
class Program
{
    public static Temperature getData(){
        
        Console.WriteLine("Enter 10 temperature values");
        float temperature = float.Parse(Console.ReadLine());
        Temperature temperr = new Temperature(temperature);
        for (int i=1; i<10; i++){
            temperr.add(float.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"Data successfully loaded");
        return temperr;
    }
    static void Main(string[] args)
    {
        float[] test = new float[10];
        Console.WriteLine(test[5]);
        Temperature data = getData();
        while(true){
            Console.WriteLine("1. Get min");
            Console.WriteLine("2. Get max");
            Console.WriteLine("3. Get average");
            Console.WriteLine("4. Get all temperatures greater than a threshold");
            Console.WriteLine("5. Reread the data");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine($"The minimum value of your data is {data.minimum()}");
                    break;
                case 2:
                    Console.WriteLine($"The maximum value of your data is {data.maximum()}");
                    break;
                case 3:
                    Console.WriteLine($"The average value of your data is {data.average()}");
                    break;
                case 4:
                    Console.WriteLine("Choose a threshold");
                    float[] above = data.allAbove(float.Parse(Console.ReadLine()));
                    Console.WriteLine("Result :");
                    foreach (float a in above){
                        Console.Write($"{a}, ");
                    }
                    Console.WriteLine();
                    break;
                case 5:
                    data = getData();
                    break;
                default:
                    Console.WriteLine("Choose a proper number");
                    break;
            }
        }
    }
}
