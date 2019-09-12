using CalculateArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив геометрических фигур, сожаржит круги и треугольники
            Figure[] figures = {    Circle.CreateCircle(2.8f),
                                    Circle.CreateCircle(-5),
                                    Triangle.CreateTriangle(1, 2.5f, 6),
                                    Triangle.CreateTriangle(-3, 5, 4),
                                    Triangle.CreateTriangle(11, 12, 13),
                                    Triangle.CreateTriangle(3, 5, 4)
                               };
            
            foreach (Figure oneFigure in figures)
            {
                if (oneFigure != null)
                    Console.WriteLine("Площадь фигуры {0} = {1}", oneFigure.ToString(), oneFigure.GetArea().ToString("f3"));
                else  
                    Console.WriteLine("Невозможно создать фигуру с заданными параметрами!");
            }
            
            Console.ReadLine();
        }
    }
}
