using System;

namespace Module_3_Task_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var asyncTask = new AsyncTask();
            var text = asyncTask.GetFullText().GetAwaiter().GetResult();
            Console.WriteLine(text);
        }
    }
}
