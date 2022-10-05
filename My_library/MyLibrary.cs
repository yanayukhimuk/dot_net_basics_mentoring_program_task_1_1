using System;

namespace My_library
{
    public static class MyLibrary
    {
        public static string ChangeOutput(this String name)
        {
            string date = DateTime.Now.ToString();
            return date + ": " + "Hello, " + name + "!";
        }
    }
}
