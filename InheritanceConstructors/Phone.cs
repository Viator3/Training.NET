using System;

namespace InheritanceConstructors
{
    class Phone
    {
        public string name;
        public string brand;

        public static void Calls()
        {
            Console.WriteLine("I know how to call ...");
        }

        public Phone(string name, string brand)
        {
            this.name = name;
            this.brand = brand;
        }
    }

    class Smartphone : Phone
    {
        public string camera;

        public Smartphone(string name, string brand, string camera) : base(name, brand)
        {
            this.camera = camera;
        }

        public static void Video()
        {
            Calls();
            Console.WriteLine("I know how to shoot and show videos ...");
        }
    }

    class Tablet : Smartphone
    {
        public int screen;

        public Tablet(string name, string brand, string camera, int screen) : base(name, brand, camera)
        {
            this.screen = screen;
        }

        public static void Game()
        {
            Video();
            Console.WriteLine("I have many games ...");
        }
    }
}
