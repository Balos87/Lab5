using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }     
    }
} 
