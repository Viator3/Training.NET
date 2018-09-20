using System;

namespace InterfaceTest
{
    class Phone : IInternalFunctions, IDeviceSheath
    {
        int screenSize;

        public string Name { get; set; }
        public string Control { get; set; }
        public string Speaker { get; set; }

        public int ScreenSize
        {
            get { return screenSize; }
        }

        public Phone(string name, int screenSize, string control)
        {
            Name = name;
            this.screenSize = screenSize;
            Control = control;
        }

        public void EnteringInformation()
        {
            Console.WriteLine("Input is carried out: {0}", Control);
        }

        public void InformationOutput()
        {
            Console.WriteLine("The sound is played back on {0}, A black and white image is displayed...", Speaker);
        }
    }


    class Smartphone : IInternalFunctions, IDeviceSheath
    {
        int screenSize;

        public string Name { get; set; }
        public string Control { get; set; }
        public string Speaker { get; set; }

        public int ScreenSize
        {
            get { return screenSize; }
        }

        public Smartphone(string name, int screenSize, string control)
        {
            Name = name;
            this.screenSize = screenSize;
            Control = control;
        }

        public void EnteringInformation()
        {
            Console.WriteLine("Input is carried out: {0}", Control);
        }

        public void InformationOutput()
        {
            Console.WriteLine("The sound is played back on {0}, Color video is played on the screen ...", Speaker);
        }
    }


    class Desktop : IInternalFunctions, IDeviceSheath
    {
        int screenSize;

        public string Name { get; set; }
        public string Control { get; set; }
        public string Speaker { get; set; }

        public int ScreenSize
        {
            get { return screenSize; }
        }

        public Desktop(string name, int screenSize, string control)
        {
            Name = name;
            this.screenSize = screenSize;
            Control = control;
        }

        public void EnteringInformation()
        {
            Console.WriteLine("Input is carried out: {0}", Control);
        }

        public void InformationOutput()
        {
            Console.WriteLine("The sound is played back on {0}, The monitor outputs any video and image...", Speaker);
        }
    }
}
