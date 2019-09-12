using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    // геометрическая фигура
    public abstract class Figure
    {
        // вычислить площадь фигуры
        public abstract float GetArea();
        // текстовое описание фигуры
        public abstract override string ToString();
    }
}
