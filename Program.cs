// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

TaskTest.Task_A();

// await TaskTest.AsyncTask();
await TaskTest.AsyncTaskNotAwait();

// Task
static class TaskTest
{
    public static void Task_A()
    {
        Console.WriteLine("Task A has done");
    }
    
    public static async Task Task_B_Async()
    {
        Console.WriteLine("B: Start awating...");
        await Task.Delay(TimeSpan.FromSeconds(10)); // time-consuming work/job
        Console.WriteLine("B: Done awating...");
        
        // do the work
        Console.WriteLine("Task B has done");
    }

    public static void Task_C()
    {
        Console.WriteLine("C: Start awating...");
        Task.Delay(TimeSpan.FromSeconds(10));
        Console.WriteLine("C: Done awating...");

        Console.WriteLine("Task C has done");
    }

    public static async Task AsyncTask()
    {
        await Task_B_Async();
        Task_C();
    }

    public static async Task AsyncTaskNotAwait()
    {
        Task_B_Async();
        Task_C();
    }
}