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
            MainMenu(MakePhoneList());
        }
        // list of phone data being added
        public static List<PhoneInfo> MakePhoneList()
        {
            List<PhoneInfo> PI = new List<PhoneInfo>();
            PI.Add(new PhoneInfo { brand = "Huawei", type = "P30", price = 697, description = "6.47 FHD + (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz), 8GB RAM, 128GB ROM, 40 + 20 + 8 + TOF / 32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1" });
            PI.Add(new PhoneInfo { brand = "Samsung", type = "Galaxy A52", price = 399, description = "64 megapixel camera, 4k videokwaliteit6.5 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP67)" });
            PI.Add(new PhoneInfo { brand = "Apple", type = "IPhone 11", price = 619, description = "Met de dubbele camera schiet je in elke situatie een perfecte foto of videoDe krachtige A13-chipset zorgt voor razendsnelle prestatiesMet Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelenHet toestel heeft een lange accuduur dankzij een energiezuinige processor" });
            PI.Add(new PhoneInfo { brand = "Google", type = "Pixel 4a", price = 411, description = "12.2 megapixel camera, 4k videokwaliteit5.81 inch OLED scherm128 GB opslaggeheugen3140 mAh accucapaciteit" });
            PI.Add(new PhoneInfo { brand = "Xiomi", type = "Redmi Note 10 Pro", price = 298, description = "108 megapixel camera, 4k videokwaliteit6.67 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP53)" });
            return PI;
        }

        // the whole process
        public static void MainMenu(List<PhoneInfo> pI)
        {
            //choose whether to enter phone numbers or exit the device
            Console.WriteLine("Press 1 for entering phone numbers or 2 for exiting the application.");
            while (true)
            {
                try
                {
                    var num = 0;
                    bool exitOn = int.TryParse(Console.ReadLine(), out num);
                    if (exitOn == true)
                    {
                        if (num == 1)
                        {
                            break;
                        }
                        else if (num == 2)
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select another number");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            Console.Clear();

            // make a list of phone numbers
            List<string> phoneNumbers = new List<string>();

            foreach (var info in pI)
            {
                Console.WriteLine("Please select a phone number for " +
                        info.brand + ". The number must contain 10 values");
                while (true)
                {
                    try
                    {
                        double num = 0;
                        bool exitOn = double.TryParse(Console.ReadLine(), out num);
                        if (num.ToString().Length == 10 && exitOn == true)
                        {
                            Console.WriteLine("The number for " + info.brand + " is: " + num);
                            phoneNumbers.Add(num.ToString());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The number must be exactly 10 values and must use the digits 0 to 9. Please try again.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.Clear();

            // overview of the numbers
            foreach (var nums in phoneNumbers)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine("The numbers have been installed. Please press a button to continue.");
            Console.ReadKey();
            Console.Clear();

            // all data put on the console
            var countIndex = 0;
            Console.WriteLine("These are the available brands along with all data");
            foreach (var info in pI)
            {
                string b = phoneNumbers.ElementAt(countIndex);
                Console.WriteLine( "Brand: " + info.brand + "    Type: " + info.type + "    Price: " + info.price + "    Number: " + b);
                Console.WriteLine();
                Console.WriteLine("Description: " + info.description);
                Console.WriteLine();
                Console.WriteLine();
                countIndex++;
            }

            Console.ReadKey();
            Console.Clear();

            //either reset the data and go back to the menu or exit the app
            while (true)
            {
                try
                {
                    Console.WriteLine("For resetting the phone numbers, press 1. If you are done with the app, press 2. For going back to the main menu, press 3.");
                    var num = 0;
                    bool exitOn = int.TryParse(Console.ReadLine(), out num);
                    if (num == 1 && exitOn == true)
                    {
                        phoneNumbers.Clear();
                    }
                    else if (num == 2 && exitOn == true)
                    {
                        foreach (var info2 in pI)
                        {
                            string d = phoneNumbers.ElementAt(countIndex);
                            Console.WriteLine("Brand: " + info2.brand + "    Type: " + info2.type + "    Price: " + info2.price + "    Number: " + d);
                            Console.WriteLine();
                            Console.WriteLine("Description: " + info2.description);
                            Console.WriteLine();
                            Console.WriteLine();
                            countIndex++;
                        }
                        return;
                    }
                    else if (num == 3 && exitOn == true)
                    {
                        Console.Clear();
                        MainMenu(pI);
                    }
                    else
                    {
                        Console.WriteLine("This number has no function. Please try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    public class PhoneInfo
    {
        public string brand { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public string description { get; set; }
    }
}
