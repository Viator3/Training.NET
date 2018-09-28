using System;

namespace NestedTest
{
    class SmartPhone
    {
        public class Touch
        {
            public void TurningOn()
            {
                Console.WriteLine("Touch On!");
            }

            public void TurningOff()
            {
                Console.WriteLine("Touch Off!");
            }
        }

        //private Touch touch;

        //public SmartPhone()
        //{
        //    this.touch = new Touch();
        //}

        //public void TouchOn()
        //{
        //    this.touch.TurningOn();
        //}

        //public void TouchOff()
        //{
        //    this.touch.TurningOff();
        //}
    }
}
