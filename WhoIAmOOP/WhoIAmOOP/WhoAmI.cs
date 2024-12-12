using System;

namespace WhoIAmOOP
{
    internal class AyanamiRey
    {
        static void Main(string[] args)
        {
            string name = "Ayanami 綾波";
            string surname = "Rey レイ";
            string sex = "Женский";

            var details = new PersonChangable(0, 14, "Чтение книг, связанных с генетикой, пилотирование Евой-00", "Tokyo-3");

            var person = new Person(sex, details);
            var personClass = new PersonClass(name, surname);

            string beautifulOutput = "\n\t\t";
            Console.WriteLine($"{beautifulOutput}" +
                              $"Имя: {personClass.Name} {beautifulOutput}" +
                              $" Фамилия: {personClass.Surname} {beautifulOutput}" +
                              $" Возраст: {person.Details.Age} {beautifulOutput}" +
                              $" Зарплата: {person.Details.GetSalary()} {beautifulOutput}" +
                              $" Пол: {person.Sex} {beautifulOutput}" +
                              $" Секрет: {person.Details.GetSecret()} {beautifulOutput}" +
                              $" Город проживания: {person.Details.Town} {beautifulOutput}" +
                              $" Хобби: {person.Details.Hobby} {beautifulOutput}");
        }
    }

    public record Person(string Sex, PersonChangable Details);

    class PersonClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public PersonClass(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }

    public record struct PersonChangable(int Salary, int Age, string Hobby, string Town)
    {
        private string Secret { get; } = "Я - искусственная форма жизни";

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
