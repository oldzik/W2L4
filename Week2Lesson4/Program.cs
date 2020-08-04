using System;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1();
            Console.ReadKey();

            Console.WriteLine("Task 2");
            Task2();
            Console.ReadKey();

            Console.WriteLine("Task 3");
            Task3();
            Console.ReadKey();

            Console.WriteLine("Task 4");
            Task4();
            Console.ReadKey();

            Console.WriteLine("Task 5");
            Task5();
            Console.ReadKey();

        }
        public static void Task1()
        {
            string name = "Irena";
            string surname = "Pracowita";
            byte age = 32;
            char gender = 'k';
            long PESEL = 88022012456;
            long employeeId = 7654345620;

            Console.WriteLine($"Imię:{name}, \r\nNazwisko:{surname},\r\nWiek:{age},\r\nPłeć:{gender},\r\nPESEL:{PESEL},\r\nNumer pracownika:{employeeId}\r\n");
        }
        public static void Task2()
        {
            Console.Write("Wprowadź pierwszą literę: ");
            char first = char.Parse(Console.ReadLine());
            Console.Write("Wprowadź drugą literę: ");
            char second = char.Parse(Console.ReadLine());
            Console.Write("Wprowadź trzecią literę: ");
            char third = char.Parse(Console.ReadLine());
            Console.WriteLine($"Odwrotnie niż zadeklarowano to:{third},{second},{first}\r\n");
        }
        public static void Task3()
        {
            Console.Write("Podaj szerokość prostokąta: ");
            double width = Double.Parse(Console.ReadLine());

            Console.Write("Podaj długość prostokąta: ");
            double length = Double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

            Console.WriteLine($"Prostokąt o szerokości {width} i długości {length} ma przekątną równą:{diagonal}.\r\n");

        }
        public static void Task4()
        {
            int number;
            string course;
            double differentNumber;

            number = 10;
            course = "DotnetSchool";
            differentNumber = 12.5;

            Console.WriteLine($"Number:{number}, course:{course}, differentNumber:{differentNumber}\r\n");

        }
        public static void Task5()
        {
            Console.WriteLine("Hello! Please fill in the form:");
            Console.Write("First Name:");
            string firstName = Console.ReadLine();

            Console.Write("Middle name:");
            string middleName = Console.ReadLine();

            Console.Write("Surname:");
            string surname = Console.ReadLine();

            Console.Write("Phone number:");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Age:");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("E-mail address:");
            string eAddress = Console.ReadLine();

            Console.Write("Weight (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Height (cm):");
            byte height = byte.Parse(Console.ReadLine());

            Console.Write("Shoe size(EU):");
            double shoeSize = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nYour personal data:");
            Console.WriteLine($"First Name: {firstName}\r\nMiddle Name: {middleName}\r\nSurname: {surname}\r\n" +
                $"Phone Number: {phoneNumber}\r\nAge: {age}\r\nEmail address: {eAddress}\r\nWeight: {weight}kg\r\nHeight: {height}cm\r\nShoe size: {shoeSize} (EU)");

        }
    }

}
