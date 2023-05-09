//Synchronous code
void PrintMessagesSynchronous()
{
    Console.WriteLine("Hello");
    Console.WriteLine("First message");//call to api/call sto service
    Thread.Sleep(3000); //wait for response 
    Console.WriteLine("Second message"); //validate the response
    Console.WriteLine("Third message");
    Console.WriteLine("Bye");

}

//PrintMessagesSynchronous();
void PrintMessagesInDifferentThreads()
{
    Console.WriteLine("Hello");
    Thread firstThread = new Thread(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("First message");
    });
    firstThread.Start();

    Thread secondThread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second message");
    });
    secondThread.Start();

    Thread thirdThread = new Thread(() =>
    {
        Thread.Sleep(3000);
        Console.WriteLine("Third message");
    });
    thirdThread.Start();

    Console.WriteLine("Bye");
}

PrintMessagesInDifferentThreads();