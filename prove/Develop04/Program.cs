using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity();
        activity.RunCountDownMessage("get ready",5);
        activity.RunSpinnerMessage("well done", 5);
    
    }
}