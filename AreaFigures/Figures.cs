using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Figures
    {
        public const float PI = 3.14f;

        /// <summary>
        /// Метод вычисления площади круга по радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>Возвращает площадь круга</returns>
        public static float AreaCircle(float radius)
        {
            float square = (float)(PI * Math.Pow(radius, 2));
            return square;
        }

        /// <summary>
        /// Метод вычисления площади треугольника по 3-м сторонам
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns>Возвращает площадь треугольника</returns>
        public static float AreaTriangle(float sideA, float sideB, float sideC)
        {
            string Msg()
            {
                return "Треугольник прямоугольный";
            }

            if ((Math.Pow(sideA, 2) + Math.Pow(sideB, 2)) == Math.Pow(sideC, 2) || (Math.Pow(sideA, 2) + Math.Pow(sideC, 2)) == Math.Pow(sideB, 2) ||
                (Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) == Math.Pow(sideA, 2))
            {
                Msg();
            }

            float perimeter = sideA + sideB + sideC;
            float halfPerimeter = perimeter / 2;

            float square = (float)Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * 
                (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return square;            
        }
    }
}
