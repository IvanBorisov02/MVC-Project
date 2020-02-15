using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hirsotram3.Models;
using Hirsotram3.Views;

namespace Hirsotram3.Controllers
{
    public class Controller
    {
        private Display display;
        private Histogram histogram;


        public Controller()
        {
            this.display = new Display();
            this.histogram = new Histogram();

            this.histogram.Count = this.display.NumbersCount;
        }

        public void Start()
        {
            histogram.FilterNumbers(display.AllNumbers);

            display.ResultPercents.Add(histogram.GetPercent(histogram.P1));
            display.ResultPercents.Add(histogram.GetPercent(histogram.P2));
            display.ResultPercents.Add(histogram.GetPercent(histogram.P3));
            display.ResultPercents.Add(histogram.GetPercent(histogram.P4));
            display.ResultPercents.Add(histogram.GetPercent(histogram.P5));

            display.Print();
        }
    }
}
