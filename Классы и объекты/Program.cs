using System;

namespace Классы_и_объекты
{
    class Planet
    {
        protected string name;

        protected double radius;
        protected double density;

        protected double sGrav;

        public void SetName(string n)
        {
            name = n;
            Console.WriteLine($"Previously discovered planet was named {this.name}. ");
        }

        public void SetRad(double rad)
        {
            radius = rad;
            Console.WriteLine($"{this.name} radius was calculated to be {this.radius} e.r. ");
        }

        public void SetDens(double den)
        {
            density = den;
            Console.WriteLine($"{this.name} density was calculated to be {this.density} e.d. ");
        }

        public void CalcGrav()
        {
            this.sGrav = this.radius * this.density;
            Console.WriteLine($"Planet {this.name}'s gravity is about {this.sGrav} e.g. ");
        }

        public Planet()
        {
            name = "Unknown";
            radius = 1;
            density = 1;

            Console.WriteLine("A planet was discovered. It's name is yet unknown, but it's radius and density are estimated to the same as Earths'. ");
        }

        public Planet(string n)
        {
            name = n;
            radius = 1;
            density = 1;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, and it's radius and density are estimated to the same as Earths'. ");
        }

        public Planet(string n, double r)
        {
            name = n;
            radius = r;
            density = 1;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, it's radius is {this.radius} e.r. and it's density is estimated to be 1 e.d. ");
        }

        public Planet(string n, double r, double d)
        {
            name = n;
            radius = r;
            density = d;

            Console.WriteLine($"A planet was discovered. It was named {this.name}, it's radius is {this.radius} e.r. and it's denisty is {this.density} e.d. ");
        }

        public Planet(Planet origPl)
        {
            Console.WriteLine($"A planet was discovered. It's a twin of a planet called {origPl.name}, it's radius is {origPl.radius} e.r. and it's denisty is {origPl.density} e.d. It was named {origPl.name}02. ");
            this.name = origPl.name + "02";
        }

        ~Planet()
        {
            Console.WriteLine($"Oh no! Planet {this.name} was destroyed!\n");
        }
    };

    class EarthLike : Planet
    {
        private double sTemp;
        private bool water;

        Atmosphere atmosphere;

        public void SetTemp(double temp)
        {
            sTemp = temp;
            Console.WriteLine($"{this.name} temperature was calculated to be {this.sTemp} Celsius. ");
        }

        public void SetWater(bool wat)
        {
            water = wat;
            if (this.water)
                Console.WriteLine($"Researchers found water on {this.name}! ");
            else
                Console.WriteLine($"Water on {this.name} was not found. ");
        }

        public void CreateAtmos(double dens, bool ox)
        {
            this.atmosphere = new Atmosphere(dens, ox);
            if (ox)
                Console.WriteLine($"{this.name} has an atmosphere. It's density is {dens} e.a.d. and it contains an oxygen.");
            else
                Console.WriteLine($"{this.name} has an atmosphere. It's density is {dens} e.a.d. and it doesn't contain an oxygen.");
        }

        public void LifeProb()
        {
            if (this.radius * this.density > 0.5 && this.radius * this.density < 1.5 && this.sTemp < 50 && this.sTemp > -30 && water && atmosphere.GetDens() > 0.8 && atmosphere.GetDens() < 3 && atmosphere.GetOxy())
                Console.WriteLine($"{this.name} is likely to be habitable ");
            else
                Console.WriteLine($"{this.name} is probably not habitable ");
        }

        public EarthLike()
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is estimated to be the same as Earth's and it probably doesn't have any water. ");
        }

        public EarthLike(string name) : base(name)
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is estimated to be the same as Earth's and it probably doesn't have any water. ");
        }

        public EarthLike(string name, double rad) : base(name, rad)
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is estimated to be the same as Earth's and it probably doesn't have any water. ");
        }

        public EarthLike(string name, double rad, double dens) : base(name, rad, dens)
        {
            sTemp = 1.2;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is estimated to be the same as Earth's and it probably doesn't have any water. ");
        }

        public EarthLike(string name, double rad, double dens, double temp) : base(name, rad, dens)
        {
            sTemp = temp;
            water = false;
            Console.WriteLine($"It is an Earth like planet. It's surface temperature is {this.sTemp} Celsius and it probably doesn't have any water. ");
        }

        public EarthLike(string name, double rad, double dens, double temp, bool wat) : base(name, rad, dens)
        {
            sTemp = temp;
            water = wat;
            if (water)
                Console.WriteLine($"It is an Earth like planet. It's surface temperature is {this.sTemp} Celsius and it has liquid water. ");
            else
                Console.WriteLine($"It is an Earth like planet. It's surface temperature is {this.sTemp} Celsius and it doesn't have any water. ");
        }
    };

    class Atmosphere
    {
        private double atmDens;
        private bool oxygen;

        public double GetDens()
        {
            return atmDens;
        }

        public bool GetOxy()
        {
            return oxygen;
        }

        public Atmosphere()
        {
            atmDens = 0;
            oxygen = false;
        }

        public Atmosphere(double dens, bool ox)
        {
            atmDens = dens;
            oxygen = ox;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {

            EarthLike pl0 = new EarthLike();
            pl0.SetName("Hyperion");
            pl0.SetRad(1.5);
            pl0.SetTemp(15.5);
            pl0.SetDens(0.8);
            pl0.CalcGrav();
            pl0.SetWater(true);
            pl0.CreateAtmos(2, true);
            pl0.LifeProb();

            Console.WriteLine($"\n");

            Planet pl1 = new Planet("X01");
            Planet pl2 = new Planet("Jupiter", 70);
            Planet pl3 = new Planet("Mars", 0.5, 0.7);
            Planet pl4 = new Planet(pl1);

            pl3.CalcGrav();
        }
    }
}
