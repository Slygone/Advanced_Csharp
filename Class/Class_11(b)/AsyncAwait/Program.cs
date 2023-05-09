void SendMessage()
{
    Console.WriteLine("Sending a message...");
    Thread.Sleep(5000); //simulate wait
    Console.WriteLine("The message was sent!");
}

SendMessage();
Console.WriteLine("Another code...");

async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sednding a message....");//part of main thread

    //the code in the task is sent away to be executed on another thread
    //the code on line 29 wont be executed untill; tis task finsiehs (5sec)
    //becasue of the code in the tas is sent away, at that moment the main thread is free
    await Task.Run(() =>
    {
        Thread.Sleep(5000);//simulate extensive operation last 5 sec
        Console.WriteLine($"Message: {message}");
    });

    Console.WriteLine("The message was sent");//part of main thread

    return;
}

void ShowAd(string product)
{
    Console.WriteLine("While you are waiting for the message to be sent, let us show you an ad");
    Console.WriteLine($"You can have this product{product} in the next 10 minutes...");
}

SendMessageAsync("Hello SEDC");
ShowAd("C# Course");
Console.ReadLine();
