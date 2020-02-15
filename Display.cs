using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hirsotram3.Views
{
    public class Display
    {
        //Изкарваме си входните данни в две пропъртита!!!

        public int NumbersCount { get; set; }
        public List<int> AllNumbers { get; set; }

        public List<double> ResultPercents { get; set; }

        public Display()
        {
            this.AllNumbers = new List<int>();
            this.ResultPercents = new List<double>();
            this.GetValues();
        }

        private void GetValues()
        {
            this.NumbersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < this.NumbersCount; i++)
            {
                this.AllNumbers.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void Print()
        {
            Console.WriteLine(String.Join(Environment.NewLine, ResultPercents.Select(x => $"{x:F2}%")));
        }
    }
}
