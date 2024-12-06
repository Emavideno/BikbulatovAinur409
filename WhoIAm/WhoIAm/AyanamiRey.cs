using System;

namespace WhoIAm
{
    internal class AyanamiRey
    {
        static void Main(string[] args)
        {
            string name = "Ayanami 綾波";
            string surname = "Rey レイ";
            int salary = 0;
            int age = 14;
            string sex = "Женский";
            string town = "Tokyo-3";
            string hobby = "Чтение книг, связанных с генетикой, пилотирование Евой-00";

            var person = new Person(name, surname, salary, age, hobby, town, sex);

            string beautifulOutput = "\n\t\t";
            Console.WriteLine($"{beautifulOutput} Имя: {person.Name} {beautifulOutput}" +
                              $" Фамилия: {person.Surname} {beautifulOutput}" +
                              $" Возраст: {person.Age} {beautifulOutput}" +
                              $" Зарплата: {person.GetSalary()} {beautifulOutput}" +
                              $" Пол: {person.Sex} {beautifulOutput}" +
                              $" Секрет: {person.GetSecret()} {beautifulOutput}" +
                              $" Город проживания: {person.Town} {beautifulOutput}" +
                              $" Хобби: {person.Hobby} {beautifulOutput}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Hobby { get; set; }
        public string Town { get; set; }
        public int Salary { private get; set; }
        private string Secret { get; } = "Я - искусственная форма жизни";

        public Person(string name, string surname, int salary, int age, string hobby, string town, string sex)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Age = age;
            Hobby = hobby;
            Town = town;
            Sex = sex;
        }

        public int GetSalary()
        {
            return Salary;
        }

        public string GetSecret()
        {
            return Secret;
        }
    }
}
