using System;

namespace FALibrary.Figures
{
    public abstract class Figure
    {
        /// <summary>
        /// Считает площядь 
        /// </summary>
        /// <returns></returns>
        internal abstract double СalculateArea();

        /// <summary>
        /// Возвращает площядь окгругленной до двух знаков после запятой
        /// </summary>
        /// <returns></returns>
        public double RoundedResult()
        {
            return Math.Round(СalculateArea(), 3);
        }
    }
}

