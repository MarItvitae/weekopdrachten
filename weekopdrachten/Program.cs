using System;
using System.Collections.Generic;
using System.Linq;



namespace weekopdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            // execute the code
            List<PhoneInfo> phoneInfos = MakePhoneList();
            bool exit = false;
            while (!exit == true)
            {
                exit = MainMenu(phoneInfos,exit);
            }
        }
        // list of phone data being added
        public static List<PhoneInfo> MakePhoneList()
        {
            List<PhoneInfo> PI = new List<PhoneInfo>();
            PI.Add(new PhoneInfo { ID = 1, brand = "Huawei", type = "P30", price = 697, description = "6.47 FHD + (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz), 8GB RAM, 128GB ROM, 40 + 20 + 8 + TOF / 32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1" });
            PI.Add(new PhoneInfo { ID = 2, brand = "Samsung", type = "Galaxy A52", price = 399, description = "64 megapixel camera, 4k videokwaliteit6.5 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP67)" });
            PI.Add(new PhoneInfo { ID = 3, brand = "Apple", type = "IPhone 11", price = 619, description = "Met de dubbele camera schiet je in elke situatie een perfecte foto of videoDe krachtige A13-chipset zorgt voor razendsnelle prestatiesMet Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelenHet toestel heeft een lange accuduur dankzij een energiezuinige processor" });
            PI.Add(new PhoneInfo { ID = 4, brand = "Google", type = "Pixel 4a", price = 411, description = "12.2 megapixel camera, 4k videokwaliteit5.81 inch OLED scherm128 GB opslaggeheugen3140 mAh accucapaciteit" });
            PI.Add(new PhoneInfo { ID = 5, brand = "Xiomi", type = "Redmi Note 10 Pro", price = 298, description = "108 megapixel camera, 4k videokwaliteit6.67 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP53)" });
            return PI;
        }

        // the whole process
        public static bool MainMenu(List<PhoneInfo> pI, bool exits)
        {
            Console.WriteLine("1: Huawei");
            Console.WriteLine("2: Samsung");
            Console.WriteLine("3: Apple");
            Console.WriteLine("4: Google");
            Console.WriteLine("5: Xiomi");
            Console.WriteLine("6: Exit");

            var num = 0;
            bool exitOn = int.TryParse(Console.ReadLine(), out num);
            Console.Clear();

            if (exitOn == true)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine($"ID: {pI[0].ID} Brand: {pI[0].brand} Type: {pI[0].type} Price: {pI[0].price}");
                        Console.WriteLine();
                        Console.WriteLine($"Description: {pI[0].description}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine($"ID: {pI[1].ID} Brand: {pI[1].brand} Type: {pI[1].type} Price: {pI[1].price}");
                        Console.WriteLine();
                        Console.WriteLine($"Description: {pI[1].description}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine($"ID: {pI[2].ID} Brand: {pI[2].brand} Type: {pI[2].type} Price: {pI[2].price}");
                        Console.WriteLine();
                        Console.WriteLine($"Description: {pI[2].description}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine($"ID: {pI[3].ID} Brand: {pI[3].brand} Type: {pI[3].type} Price: {pI[3].price}");
                        Console.WriteLine();
                        Console.WriteLine($"Description: {pI[3].description}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine($"ID: {pI[4].ID} Brand: {pI[4].brand} Type: {pI[4].type} Price: {pI[4].price}");
                        Console.WriteLine();
                        Console.WriteLine($"Description: {pI[4].description}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;

                    case 6:
                        exits = true;
                        break;

                    default:
                        break;
                    
                }
            }

            
            Console.Clear();

            return exits;

            
        }
    }
}
