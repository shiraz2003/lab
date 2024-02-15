using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapdata data = new Encapdata();
            Console.Write("enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            data.radius = radius;

        }
    }
    class Encapdata {
        private double radius;
        private double pi = 3.142;

        public double radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double calculatearea()
        {
            double area = pi 
        }
    }
}
