using System;

namespace Классы_и_объекты
{
    class Planet
    {
        public string name;

        protected double radius;
        protected double density;

        private double sGrav;

        public void CalcGrav()
        {
            this.sGrav = this.radius * this.density;
            Console.WriteLine($"Planet {this.name}'s gravity is about {this.sGrav} e.g.\n");
        }

        public Planet()
        {
            name = "Unknown";
            radius = 1;
            density = 1;

            Console.WriteLine("A planet was discovered. It's name is yet unknown, but it's radius and density are estimated to the same as Earths'.\n");
        }

        public Planet(string n)
        {
            name = n;
            radius = 1;
            density = 1;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, and it's radius and density are estimated to the same as Earths'.\n");
        }

        public Planet(string n, double r)
        {
            name = n;
            radius = r;
            density = 1;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, it's radius is {this.radius} e.r. and it's density is 1 e.d.\n");
        }

        public Planet(string n, double r, double d)
        {
            name = n;
            radius = r;
            density = d;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, it's radius is {this.radius} e.r. and it's denisty is {this.density} e.d.\n");
        }

        public Planet(Planet origPl)
        {
            Console.WriteLine($"A planet was discovered. It's a twin of a planet called {origPl.name}, it's radius is {origPl.radius} e.r. and it's denisty is {origPl.density} e.d. It was named {origPl.name}02.\n");
            this.name = origPl.name + "02";
        }

        ~Planet()
        {
            Console.WriteLine($"Oh no! Planet {this.name} was destroyed!\n\n");
        }
    };

    class EarthLike : Planet
    {
        private double sTemp;
        private bool water;

        public void LifeProb()
        {
            if (this.radius * this.density > 0.5 && this.radius * this.density < 1.5 && this.sTemp < 50 && this.sTemp > -30 && water)
                Console.WriteLine($"{this.name} is likely to be habitable\n");
            else
                Console.WriteLine($"{this.name} is probably not habitable\n");
        }

        public EarthLike()
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is the same as Earth's and it doesn't have any water.\n");
        }

        public EarthLike(string name) : base(name)
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is the same as Earth's and it doesn't have any water.\n");
        }

        public EarthLike(string name, double rad) : base(name, rad)
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is the same as Earth's and it doesn't have any water.\n");
        }

        public EarthLike(string name, double rad, double dens) : base(name, rad, dens)
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is the same as Earth's and it doesn't have any water.\n");
        }

        public EarthLike(string name, double rad, double dens, double temp) : base(name, rad, dens)
        {
            sTemp = temp;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is {this.sTemp} Celsius and it doesn't have any water.\n");
        }

        public EarthLike(string name, double rad, double dens, double temp, bool wat) : base(name, rad, dens)
        {
            sTemp = temp;
            water = wat;
            if (water)
                Console.WriteLine($"It is an Earth like planet. It's surface temperature is {this.sTemp} Celsius and it has liquid water.\n");
            else
                Console.WriteLine($"It is an Earth like planet. It's surface temperature is {this.sTemp} Celsius and it doesn't have any water.\n");
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            EarthLike pl0 = new EarthLike("Hyperion", 2, 0.8, 13.5, true);
            pl0.CalcGrav();
            pl0.LifeProb();
            //Planet pl1 = new Planet("X01");
            //Planet pl2 = new Planet("Jupiter", 70);
            //Planet pl3 = new Planet("Mars", 0.5, 0.7);
            //Planet pl4 = new Planet(pl1);

            //pl3.CalcGrav();
        }
    }
}
