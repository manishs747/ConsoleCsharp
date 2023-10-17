using ManishConsoleApp.oops.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Threading;

namespace ManishConsoleApp.async
{
    public static class ThreadSamples
    {

        public static void Main()
        {
            ThreadCreation();
            AsyncCreation();
        }


        private static async void AsyncCreation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            await DoAsyncWork(1);
            await DoAsyncWork(2);
            Task t3 = DoAsyncWork(3);
            Task t4 = DoAsyncWork(4);
            Task t5 = DoAsyncWork(5);
            Task t6 = DoAsyncWork(6);

            await Task.WhenAll(t3,t4,t5,t6);

            Console.WriteLine("Work happening in main thread.");

            Console.WriteLine("After all done");
        }

        public static async Task DoAsyncWork(int n)
        {
            await Task.Delay(2000);
            Console.WriteLine($"Inside task {n}");
        }




        private static void ThreadCreation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            Thread t = new Thread(DoFileWork);

            t.Start();
            t.Join();
            Console.WriteLine("Work happening in main thread.");

            Console.WriteLine("After all done");
        }

        public static void DoFileWork()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            string filePath = "..\\..\\..\\matt.json";
            //this could take a while
            var employeeJson = File.ReadAllText(filePath);

            var matt = JsonSerializer.Deserialize<Employee>(employeeJson);

            Console.WriteLine($"Employee read from file: {matt}");
        }

        //File.BeginReadAllText(filePath, EndReadingFile, state);

        //public void EndReadingFile(object state, IAsyncResult iar){
        //handle the completion of file reading
        //}

        public static async Task SimpleThreadAsync()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            Task tMatt = DoFileWorkAsync("matt");
            Task tFelicia = DoFileWorkAsync("felicia");

            Console.WriteLine("Work happening in main thread.");

            await Task.WhenAll(tMatt, tFelicia);

            //THIS IS where the callback code happens


        }

        public static async Task DoFileWorkAsync(string employeeName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            string filePath = $"..\\..\\..\\{employeeName}.json";
            var employeeJson = await File.ReadAllTextAsync(filePath);

            var matt = JsonSerializer.Deserialize<Employee>(employeeJson);

            Console.WriteLine($"Employee read from file: {matt}");
        }
    }
}
