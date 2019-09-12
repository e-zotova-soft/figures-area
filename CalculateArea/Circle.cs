using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    // геометрическая фигура круг
    public class Circle: Figure
    {
        // радиус
        private float radius;

        private Circle(float radius)
        {
            this.radius = radius;
        }

        // создание объекта в специальном методе, только если входные параметры прошли условие проверки
        public static Circle CreateCircle(float radius)
        {
            if (Exists(radius)) return new Circle(radius);
            else return null; 
        }

        // проверка существования круга с заданным радиусом, вырожденный круг не разрешаем
        public static bool Exists(float radius)
        {
            if (radius > 0)
                return true;
            else
                return false;
        }

        // вычисление площади
        public override float GetArea()
        {
            float area = (float) Math.PI * radius * radius;
            return area;
        }

        // текстовое описание
        public override string ToString()
        {
            String name = String.Format("Круг (радиус: {0})", radius);
            return name;
        }
    }
}
