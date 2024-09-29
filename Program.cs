using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2all1
{
    class Person
    {
        // Поля класса
        private string name;
        private int age;
        private string address;

        // Конструктор
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // Методы для получения значений полей
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetAddress()
        {
            return address;
        }

        // Методы для установки значений полей
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        // Метод для вывода информации о человеке
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Информация о человеке с помощью класса------------------");
            // Создание объектов класса Person
            Person person1 = new Person("Анна Букштынова", 17, "д. Богдановка");
            Person person2 = new Person("Ксюша Кирсанова", 17, "Витебск");

            // Вывод информации
            person1.PrintInfo();
            person2.PrintInfo();

            // Изменение значений полей
            person1.SetAge(18);
            person1.SetAddress("Орша");

            // Вывод обновленной информации
            person1.PrintInfo();
            Console.ReadLine();



            Console.WriteLine("-----------------Наследование и полиморфизм------------------");

        }
    }
}

