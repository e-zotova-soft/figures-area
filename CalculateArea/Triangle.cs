using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    // геометрическая фигура треугольник
    public class Triangle : Figure
    {
        private float side1;
        private float side2;
        private float side3;

        private Triangle(float side1, float side2, float side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;            
        }

        // создание объекта в специальном методе, только если входные параметры прошли условие проверки
        public static Triangle CreateTriangle(float side1, float side2, float side3)
        {
            if (Exists(side1, side2, side3)) return new Triangle(side1, side2, side3);
            else return null; 
        }

        // проверка существования треугольника с заданными параметрами сторон
        public static bool Exists(float side1, float side2, float side3)
        {
            // у треугольника сумма любых двух сторон должна быть больше третьей
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                return true;
            else
                return false;
        }
       
        // вычисление периметра
        public float Perimeter()
        {
            return side1 + side2 + side3;
        }

        // вычисление площади
        public override float GetArea()
        {
            float p = Perimeter() / 2;
            float area = (float) Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return area;            
        }

        // текстовое описание
        public override string ToString()
        {
            String name = String.Format("Треугольник (стороны: {0}, {1}, {2}; {3})", side1, side2, side3, IsRectangular() ? "прямоугольный": "непрямоугольный");
            return name;
        }

        // проверка, является ли треугольник прямоугольным
        public bool IsRectangular()
        {
            // найти значение гипотенузы
            float max = new float[] { side1, side2, side3 }.Max();            
            // проверка, выполняется ли для треугольника теорема Пифагора
            if (max == side1)
            {
                if (side1 * side1 == side2 * side2 + side3 * side3) return true;
            }
            if (max == side2)
            {
                if (side2 * side2 == side1 * side1 + side3 * side3) return true;
            }
            if (max == side3)
            {
                if (side3 * side3 == side1 * side1 + side2 * side2) return true;
            }
            return false;
        }
    }
}
