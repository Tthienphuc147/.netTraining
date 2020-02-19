using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }
        public Circle(double r)
        {
            this.radius = r;
        }
        public Circle(double r,string c)
        {
            this.radius = r;
            this.color = c;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public double getArea()
        {
            return this.radius * this.radius * Math.PI;
        }
        
    }
}
