
using System;

class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunActivity()
    {
        StartActivity();

        RunCountDownMessage("Get Ready", 5);

        StartTimer();

        while (!HasTimerExpired())
        {
            RunCountDownMessage("Breathe in", 4);
            RunCountDownMessage("Breathe out", 6);
        }

        EndActivity();
    }
}
