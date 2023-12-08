class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string gender, string position)
        : base(name, age, gender)
    {
        Position = position;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Петя", 18, "Мужской");
        Console.WriteLine($"Человек: {person.Name}, Возраст: {person.Age}, Пол: {person.Gender}");

        Employee employee = new Employee("Маша", 25, "Женский", "Документовед");
        Console.WriteLine($"Работник: {employee.Name}, Возраст: {employee.Age}, Пол: {employee.Gender}, Должность: {employee.Position}");

        Console.ReadKey(true);
    }
}
