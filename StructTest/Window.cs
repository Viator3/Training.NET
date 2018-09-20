using System;

namespace StructTest
{
    struct WindowProperties
    {
        public int width, height;

        public void Open()
        {
            Console.WriteLine("Open window...");
        }

        public void Close()
        {
            Console.WriteLine("Close window...");
        }
    }

    class Window
    {
        public void showWindow(WindowProperties windowProperties)
        {
            Console.WriteLine("Window width = {0}, Window height = {1};", windowProperties.width, windowProperties.height);
            Console.WriteLine("\nPossible actions with windows:");
            windowProperties.Open();
            windowProperties.Close();
        }
    }
}
