using System;

namespace Классы_и_объекты
{
    class Planet
    {
        public string name;
        private double radius;
        private double density;

        private double sGrav;

        public void CalcGrav()
        {
            this.sGrav = this.radius * this.density;
            Console.WriteLine($"Planet {this.name}'s gravity is about {this.sGrav} e.g.\n\n");
        }

        public Planet()
        {
            name = "Unknown";
            radius = 1;
            density = 1;

            Console.WriteLine("A planet was discovered. It's name is yet unknown, but it's radius and density are estimated to the same as Earths'.\n\n");
        }

        public Planet(string n)
        {
            name = n;
            radius = 1;
            density = 1;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, and it's radius and density are estimated to the same as Earths'.\n\n");
        }

        public Planet(string n, double r)
        {
            name = n;
            radius = r;
            density = 1;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, it's radius is {this.radius} e.r. and it's density is 1 e.d.\n\n");
        }

        public Planet(string n, double r, double d)
        {
            name = n;
            radius = r;
            density = d;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, it's radius is {this.radius} e.r. and it's denisty is {this.density} e.d.\n\n");
        }

        public Planet(Planet origPl)
        {
            Console.WriteLine($"A planet was discovered. It's a copy of a planet called {origPl.name}, it's radius is {origPl.radius} e.r. and it's denisty is {origPl.density} e.d. It was named {origPl.name}02.\n\n");
            this.name = origPl.name + "02";
        }

        ~Planet()
        {
            Console.WriteLine($"Oh no! Planet {this.name} was destroyed!\n\n");
        }
    }

    class EarthLike : Planet
    {
        private double sTemp;
        private float water;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Planet pl0 = new Planet();
            Planet pl1 = new Planet("X01");
            Planet pl2 = new Planet("Jupiter", 70);
            Planet pl3 = new Planet("Mars", 0.5, 0.7);
            Planet pl4 = new Planet(pl1);

            pl3.CalcGrav();
        }
    }
}
