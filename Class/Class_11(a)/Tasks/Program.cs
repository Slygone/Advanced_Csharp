//this code belongs to the initial thread
Console.WriteLine("Hello!");

//creating a task, no result
Task firstTask = new Task(() =>
{
    Console.WriteLine("Hello from first Task!");
});

//give this task to a free thread
firstTask.Start();


//task that returns a value

Task<int> taskWithReturnValue = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Returning a value!");
    return 10;
});
taskWithReturnValue.Start();



Task.Run(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Code that executes imminently!");
});
//this waits for result(block the current code)
Console.WriteLine(taskWithReturnValue.Result);

Console.ReadLine(); 
