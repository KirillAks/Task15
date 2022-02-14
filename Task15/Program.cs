using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
            //метод void setStart(int x) - устанавливает начальное значение
            //метод int getNext() - возвращает следующее число ряда
            //метод void reset() - выполняет сброс к начальному значению
            //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
            //В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
            Console.Write("Укажите значение первого члена прогрессии: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите шаг прогрессии: ");
            int s = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            arithProgression.setStart(x);
            arithProgression.setStep(s);
            geomProgression.setStart(x);
            geomProgression.setStep(s);
            Console.WriteLine($"Значение второго члена арифметической прогрессии равно {arithProgression.getNext()}");
            Console.WriteLine($"Значение третьего члена арифметической прогрессии равно {arithProgression.getNext()}");
            Console.WriteLine($"Значение четвертого члена арифметической прогрессии равно {arithProgression.getNext()}\n");
            Console.WriteLine($"Значение второго члена геометической прогрессии равно {geomProgression.getNext()}");
            Console.WriteLine($"Значение третьего члена геометической прогрессии равно {geomProgression.getNext()}");
            Console.WriteLine($"Значение четвертого члена геометической прогрессии равно {geomProgression.getNext()}\n");
            Console.WriteLine($"Выполним сброс к начальному значению прогрессий:\n");
            arithProgression.reset();
            geomProgression.reset();
            Console.WriteLine($"Значение второго члена арифметической прогрессии равно {arithProgression.getNext()}");
            Console.WriteLine($"Значение третьего члена арифметической прогрессии равно {arithProgression.getNext()}");
            Console.WriteLine($"Значение четвертого члена арифметической прогрессии равно {arithProgression.getNext()}\n");
            Console.WriteLine($"Значение второго члена геометической прогрессии равно {geomProgression.getNext()}");
            Console.WriteLine($"Значение третьего члена геометической прогрессии равно {geomProgression.getNext()}");
            Console.WriteLine($"Значение четвертого члена геометической прогрессии равно {geomProgression.getNext()}\n");
            Console.ReadKey();
        }
    }
}
