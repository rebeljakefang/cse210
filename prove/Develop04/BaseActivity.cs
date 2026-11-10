class BaseActivity
{
    public BaseActivity()
    {
        //complete
    }
    public void RunCountDownMessage(string message, int seconds)
    {
        BaseActivity activity = new BaseActivity();
        for(int i = seconds; i>0; i--)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine($"{message} - {i}:");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }
    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        //DateTime Now = DateTime.Now
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        //for(int i = 0; i < seconds; i ++);
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
}