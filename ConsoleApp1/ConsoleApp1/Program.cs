using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApplication10
{
    struct PRICE
    {

        public string product_name; // название товара 
        string provider; // поставщик
        public int price; // цена товара
        public int volume; // количество



        public override string ToString()
        {
            return (string.Format(@"
                                    Название товара: {0}
                                    Название поставщика: {1}
                                    Стоимость товара(в рублях): {2}            
                                    Количество: {3}", product_name, provider, price, volume));
        }



        class Program
        {
            //╔═══╗╔═══╗╔══╗╔═══╗╔═══╗
            //║╔═╗║║╔═╗║╚╣─╝║╔═╗║║╔══╝
            //║╚═╝║║╚═╝║─║║─║║─╚╝║╚══╗ 
            //║╔══╝║╔╗╔╝─║║─║║─╔╗║╔══╝
            //║║───║║║╚╗╔╣─╗║╚═╝║║╚══╗
            //╚╝───╚╝╚═╝╚══╝╚═══╝╚═══╝
            //╔═══╗╔════╗╔═══╗╔╗─╔╗╔═══╗╔════╗
            //║╔═╗║║╔╗╔╗║║╔═╗║║║─║║║╔═╗║║╔╗╔╗║
            //║╚══╗╚╝║║╚╝║╚═╝║║║─║║║║─╚╝╚╝║║╚╝
            //╚══╗║──║║──║╔╗╔╝║║─║║║║─╔╗──║║──
            //║╚═╝║──║║──║║║╚╗║╚═╝║║╚═╝║──║║──
            //╚═══╝──╚╝──╚╝╚═╝╚═══╝╚═══╝──╚╝──

            static void Main(string[] args)
            {
                Console.WriteLine("╔═══╗╔═══╗╔══╗╔═══╗╔═══╗");
                Console.WriteLine("║╔═╗║║╔═╗║╚╣─╝║╔═╗║║╔══╝");
                Console.WriteLine("║╚═╝║║╚═╝║─║║─║║─╚╝║╚══╗");
                Console.WriteLine("║╔══╝║╔╗╔╝─║║─║║─╔╗║╔══╝");
                Console.WriteLine("║║───║║║╚╗╔╣─╗║╚═╝║║╚══╗");
                Console.WriteLine("╚╝───╚╝╚═╝╚══╝╚═══╝╚═══╝");
                Console.WriteLine("");
                Console.WriteLine("╔═══╗╔════╗╔═══╗╔╗─╔╗╔═══╗╔════╗");
                Console.WriteLine("║╔═╗║║╔╗╔╗║║╔═╗║║║─║║║╔═╗║║╔╗╔╗║");
                Console.WriteLine("║╚══╗╚╝║║╚╝║╚═╝║║║─║║║║─╚╝╚╝║║╚╝");
                Console.WriteLine("╚══╗║──║║──║╔╗╔╝║║─║║║║─╔╗──║║──");
                Console.WriteLine("║╚═╝║──║║──║║║╚╗║╚═╝║║╚═╝║──║║──");
                Console.WriteLine("╚═══╝──╚╝──╚╝╚═╝╚═══╝╚═══╝──╚╝──");
                Console.WriteLine("");
                Console.WriteLine("Press enter to start");
                Console.ReadKey(true);


                Console.WriteLine("Введите количество товара в каталоге");
                int number_of_structures = Convert.ToInt32(Console.ReadLine());
                PRICE[] massiv = new PRICE[number_of_structures];
                for (int i = 0; i < number_of_structures; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Название товара: ");
                    massiv[i].product_name = Console.ReadLine();
                    Console.WriteLine("Название магазина: ");
                    massiv[i].provider = Console.ReadLine();
                    //Нужно добавить сортировку для названий поставщиков по алфавиту (+ вывод в консоль)
                    Console.WriteLine("Стоимость товара(в рублях): ");
                    massiv[i].price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Количество: ");
                    massiv[i].volume = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.WriteLine("Информация в базе:");
                //Вывод массивов 
                for (int i = 0; i < number_of_structures; i++)
                    Console.WriteLine(massiv[i]);
                    Console.WriteLine("");

                Console.WriteLine("Вывод записей, упорядоченных в алфавитном порядке названий поставщиков");
                Console.WriteLine("##########Не Разработано##########");
                Console.WriteLine("");
                Console.ReadKey(true);
                //
                Console.WriteLine("Вывод информации о товаре, чьё название введено с клавиатуры");
                Console.WriteLine("##########Разработано##########");
                Console.WriteLine("Введите название товара: ");
                Console.WriteLine("");
                Console.ReadKey(true);
                string user_product_name = Convert.ToString(Console.ReadLine());
                int k = 0;
                for (int i = 0; i < number_of_structures; i++)
                {
                    if (massiv[i].product_name == user_product_name)
                    {
                        Console.WriteLine(massiv[i]); k++;
                    }
                }

                if (k == 0) Console.WriteLine("Этого товара не существует!");
                Console.ReadKey(true);
                //
                Console.WriteLine("Вывести общую сумму стоимости товаров у поставщика, название которого вводится с клавиатуры.");
                Console.WriteLine("##########Разработано##########");
                Console.WriteLine("Введите название поставщика : ");
                Console.WriteLine("");
                Console.ReadKey(true);
                string user_provider = Convert.ToString(Console.ReadLine());
                int h = 0;
                for (int i = 0; i < number_of_structures; i++)
                {
                    if (massiv[i].provider == user_provider)
                    {
                        Console.WriteLine("Общая сумма стоимости товара у поставщика: " + massiv[i].price * massiv[i].volume); h++;
                    }
                }

                if (h == 0) Console.WriteLine("Этого товара не существует !");
                Console.ReadKey(true);
            }

        }
    }
}
