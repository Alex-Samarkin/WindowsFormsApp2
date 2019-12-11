using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class MyData
    {
        /// <summary>
        /// Название серии
        /// </summary>
        public string Title { get; set; } = "Мои данные";
        /// <summary>
        /// данные по Х b Y
        /// </summary>
        public List<double> X { get; set; } = new List<double>();
        public List<double> Y { get; set; } = new List<double>();

        /// <summary>
        /// добавить точку
        /// </summary>
        /// <param name="x">координата х</param>
        /// <param name="y">координата у</param>
        public void AddXY(double x, double y)
        {
            X.Add(x);
            Y.Add(y);
        }
        /// <summary>
        /// добавить несколько точек
        /// </summary>
        /// <param name="N"> количество точек</param>
        public void AddN(int N)
        {
            //удаляем старые данные
            X.Clear();
            Y.Clear();
            //генератор случайных чисел
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                //создаем и добавляем данные
                AddXY(i, rnd.NextDouble());
            }
        }
    }
}
