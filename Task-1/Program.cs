using System;

namespace Task18march
{
    class Program
    {
        static void Main(string[] args)
        {



            int Length;
            string LengthStr;
            Console.WriteLine("Enter the number of Cars :");
            LengthStr = Console.ReadLine();

            while (CheckDouble(LengthStr) != true)
            {
                Console.WriteLine("Enter Correctly :");
                LengthStr = Console.ReadLine();

            }

            Length = Convert.ToInt32(LengthStr);

            Car[] cars = new Car[Length];
            for (int i = 0; i < Length; i++)
            {


                Console.WriteLine($"------------------------------------------------------ {i+1} st  Car  ------------------------------------------------------");


                string Color        = GetInputStr   ($"{i + 1} - Enter Color : ", 3, 20);
                string Brand        = GetInputStr   ($"{i + 1} - Enter Brand Name : ", 2, 20);
                double Millage      = GetInputDouble($"{i + 1} - Enter Millage", 0, 350);
                double FuelCapacity = GetInputDouble($"{i + 1} - Enter Fuel Capacity:", 5, 45);
                double FuelForOneKm = GetInputDouble($"{i + 1} - Enter Fuel For 1 Km:", 5, 45);
                double CurrentFuel  = GetInputDouble($"{i + 1} - Enter Current Fuel:", 5, 40);

                cars[i] = new Car(Millage, FuelCapacity, FuelForOneKm, CurrentFuel)
                {
                    Color = Color,
                    Brand = Brand

                };
            }
            static double GetInputDouble(string name, double min, double max)
            {
                string InputStr;
                double Input;

                do
                {
                    Console.WriteLine(name);
                    InputStr = Console.ReadLine();
                    double.TryParse(InputStr, out Input);

                } while (Input < 0 || Input > 350);




                while (CheckDouble(InputStr) != true)
                {
                    Console.WriteLine("Enter Corretly");
                    InputStr = Console.ReadLine();
                    double.TryParse(InputStr, out Input);

                }

                return Input;
            }

            static string GetInputStr(string str, int min, int max)
            {
                string input;

                do
                {

                    Console.WriteLine(str);
                    input = Console.ReadLine();



                } while (input.Length <= 2 || input.Length >= 15);


                while (CheckString(input) != true)
                {
                    Console.WriteLine("Enter Corretly : ");
                    input = Console.ReadLine();

                }


                return input;

            }
            static bool CheckString(string name)
            {

                if (!string.IsNullOrWhiteSpace(name) && name.Length < 10)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            return false;
                        }
                    }
                    return true;

                }
                return false;
            }
            static bool CheckDouble(string number)
            {

                if (!string.IsNullOrWhiteSpace(number) && number.Length < 60)
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (!char.IsDigit(number[i]))
                        {
                            return false;
                        }
                    }
                    return true;

                }
                return false;
            }


            do
            {

                   Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
                   Console.WriteLine("------------------------------------------------- Choose an option -----------------------------------------------------\n");
                   Console.WriteLine("1-  Filter Your Cars by Millage ");
                   Console.WriteLine("2 - Show All Cars");
                   Console.WriteLine("0 - Exit  \n");
                   Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                string Search = Console.ReadLine();
                int count = Convert.ToInt32(Search);

                if (count == 1)
                {

                    Console.WriteLine("Enter Min and Max Millage:");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Min Millage:");
                    double minMillage = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Max Millage:");

                    double maxMillage = Convert.ToDouble(Console.ReadLine());

                    var NewArr = FilterByMillage(cars, minMillage, maxMillage);

                    Console.WriteLine("-------------------------------------------------- Filtered Cars ------------------------------------------------------");
                    foreach (var item in NewArr)
                    {

                        Console.WriteLine(item.GetInfo());
                       
                    }
                    continue;

                }
                else if (count == 2)
                {
                    Console.WriteLine("----------------------------------------------------- All Cars ---------------------------------------------------------");
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine(cars[i].GetInfo());
                        
                    }
                    continue;
                }

                else if (count == 0)
                {
                    Console.WriteLine("|--------------------------------------------- Program Ended ----------------------------------------------------------|");

                    break;
                }
                else
                {
                    continue;
                }


            } while (true);





           

            static Car[] FilterByMillage(Car[] cars, double minMillage, double maxMillage)
            {
                Car[] NewArr = new Car[cars.Length];
                int count = 0;


                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Millage >= minMillage && cars[i].Millage <= maxMillage)
                    {
                        NewArr[count] = cars[i];
                        count++;
                    }
                }

                Car[] NewFilteredArr = new Car[count];

                for (int i = 0; i < count; i++)
                {
                    NewFilteredArr[i] = cars[i];
                }

                return NewFilteredArr;
            }





        }
    }
}

