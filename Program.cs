// 001.Создать систему классов для хранения геометрических фигур. 

// Пользователь должен выбрать тип фигуры, ввести требуемые 
// программой данные и получить информацию о фигуре: её площадь,
// периметр, пользовательское имя и специальное название (если есть).
// Предусмотреть проверку корректности вводимых данных.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using shapes;

namespace shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу");
            Console.WriteLine("Выберите тип фигуры:\n1-Треугольник;\n2-Прямоугольник;\n3-Окружность.");
            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
            {
                Triangles ta = new Triangles();

                Console.WriteLine("Укажите размерность треугольника в (см)");

                Console.Write("Укажите сторону A: ");
                ta.sideA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Укажите сторону B: ");
                ta.sideB = Convert.ToDouble(Console.ReadLine());

                Console.Write("Укажите сторону C: ");
                ta.sideC = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine($"Диаметр треугольника: {ta.PerimeterShape(ta.sideA, ta.sideB, ta.sideC)} (см)");
                Console.WriteLine($"Площадь треугольника: {ta.SquareShape(ta.sideA, ta.sideB, ta.sideC)} (см кв)");
            }

            else if (action == 2)
            {
                Rectangle ra = new Rectangle();

                Console.WriteLine("Укажите размерность прямоугольника в (см)");


                Console.Write("Укажите сторону A: ");
                ra.sideA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Укажите сторону B: ");
                ra.sideB = Convert.ToDouble(Console.ReadLine());

                Console.Write("Укажите сторону C: ");
                ra.sideC = Convert.ToDouble(Console.ReadLine());

                Console.Write("Укажите сторону D: ");
                ra.sideD = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Диаметр треугольника: {ra.PerimeterShape(ra.sideA, ra.sideB, ra.sideC, ra.sideD)} (см)");
                Console.WriteLine($"Площадь треугольника: {ra.SquareShape(ra.sideA, ra.sideB, ra.sideC, ra.sideD)} (см кв)");
            }
            else if (action == 3)
            {
                Circle circle = new Circle();
                Console.WriteLine("Укажите размерность окружности в (см)");
                Console.Write("Укажите радиус окружности: ");
                circle.sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Диаметр окружности: {circle.PerimeterShape(circle.sideA)} (см)");
                Console.WriteLine($"Площадь окружности: {circle.SquareShape(circle.sideA)} (см кв)");
            }
        }
    }
}
