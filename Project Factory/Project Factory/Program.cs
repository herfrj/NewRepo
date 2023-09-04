using System.Reflection;
class Global
{


    class Factory
    {
        public string title = "Unknown"; // название

        public void AddNewEmployee() // методом добавляю нового сотрудника ?????
        {
            Worker worker1 = new Worker(); // создание обьекта worker1 с типом Worker
            //Worker mike = new Worker { age = 31, name = "Mike", surname = "Ehrmantraut", position = "Engineer", activity = "coffee" }; // инициализация обьекта

        }
        public void EmployeeList() // методом вывести список всех сотрудников(имя + фамилия).
        {
            Worker list1 = new Worker();
            list1.PrintNameSurname();
        }
        public void SortByPosition()// методом вывести сотрудников с определенной должности.
        {

        }
    }
    class Employee
    {
        public string[] numWorkers = new string[10]; // массив, количество работников

        public void WorkersNumber() // методом возвращаю количество работников (массив)
        {
            var lenth1 = numWorkers.Length;
        }
    }



    class Worker // этот класс должен находиться в другом проекте, который будет библиотекой, но пока что оставил здесь, чтобы проще было.
    {
        public int age;// age
        public string name;// name
        public string surname;// surname
        public string position;// position
        public string activity;// activity

        public void Print() // методом вывожу всю инфу о работнике
        {
            Console.WriteLine($"Age: {age}, Name: {name} Surname: {surname}, Position: {position}"); // методом возвращает всю инфу о сотруднике
        }
        public void PrintNameSurname() // методом вывожу имя и фамилию
        {
            Console.WriteLine($"{name} {surname}");
        }

        public void Misc() // методом вывожу деятельность сотрудника
        {
            Console.WriteLine($"{name} {surname}, Activity: {activity}");
        }
    }
}