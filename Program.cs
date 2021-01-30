using System;

namespace ConsoleApp76
{
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public int experinece { get; set; }




        public Employee(string name, string surname, string position, int experinece)
        {
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.experinece = experinece;
        }

        public double salary;



        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} \nSurname: {surname} \nPosition: {position}\nExperience: {experinece}");
        }
        public void esliposition()
        {
            if (position == "Doctor")
            {

                if (experinece <= 3)
                {
                    salary = 1800 - (1800 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (experinece >= 4)
                {
                    salary = 2200 - (2200 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (position == "Teacher")
            {

                if (experinece <= 3)
                {
                    salary = 1800 - (1800 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (experinece >= 4)
                {
                    salary = 2200 - (2200 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (position == "Programmer")
            {
                if (experinece <= 1)
                {
                    salary = 2000 - (2000 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (experinece >= 2)
                {
                    salary = 3200 - (3200 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (position == "Manager")
            {
                if (experinece <= 1)
                {
                    salary = 2900 - (2900 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (experinece >= 2)
                {
                    salary = 3400 - (3400 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            if (position == "Driver")
            {
                if (experinece <= 1)
                {
                    salary = 900 - (900 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (experinece >= 2)
                {
                    salary = 1100 - (1100 * 14 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша заработная плата c учетом налогов и пенсионного фонда = " + salary + "TJS");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Введите ответы исключительно латинскими буквами (1 - буква должна быть с большой)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your name = ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname = ");
            string surname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The information is available ONLY for these vacancies \n1 - Doctor \n2 - Manager \n3 - Teacher \n4 - Programmer \n5 - Driver \nВведите ТОЛЬКО название вакансии!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите должность = ");
            string position = Console.ReadLine();
            Console.WriteLine("Введите стаж = ");
            int experinece = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee(name, surname, position, experinece);
            employee.GetInfo();
            employee.esliposition();


        }
    }
}

