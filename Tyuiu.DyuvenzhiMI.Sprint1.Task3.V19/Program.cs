//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчёты: Написать программу, которая печатает true или false в зависимости от того,
//может ли шахматная фигура «Слон» с одного заданного поля шахматной доски перейти за один ход на другое.
//Пользователь задаёт координаты двух ячеек шахматной доски (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).

using Tyuiu.DyuvenzhiMI.Sprint1.Task3.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19                                                              *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1;  double x2; double y1; double y2;

        Console.WriteLine("Введите координату x1:");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату y1:");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату x2:");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату y2:");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        //Метод ElephCanMove находится в библиотеке Tyuiu.DyuvenzhiMI.Sprint1.Task3.V19.Lib
        //в классе DataService
        Console.WriteLine(ds.ElephCanMove(x1, x2, y1, y2));

        Console.ReadKey();
    }
}