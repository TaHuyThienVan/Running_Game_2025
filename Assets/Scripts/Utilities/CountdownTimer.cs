using System;

public class CountdownTimer
{
    float timer;
    float startTime;
    public Action OnTimerEnd;
    private bool isAutoReset = false;
    private bool isPaused = false;

    public float Timer => timer;
    public float StartTime => startTime;
    public bool IsAutoReset => isAutoReset;

    public CountdownTimer(float time, bool isAutoReset = true, bool isPause = false)
    {
        startTime = time;
        timer = time;
        this.isPaused = isPause;
        SetAutoReset(isAutoReset);

    }
    public void UpdateTimer(float deltaTime)
    {
        if (isPaused)
        {
            return;
        }
        if (timer > 0)
        {
            timer -= deltaTime;
            return;
        }
        OnTimerEnd?.Invoke();
    }

    public void SetAutoReset(bool value)
    {
        if (value == isAutoReset)
            return;
        isAutoReset = value;
        if (isAutoReset)
        {
            OnTimerEnd += ResetTimer;
        }
        else
        {
            OnTimerEnd -= ResetTimer;
        }
    }

    public void FinishTimer()
    {
        timer = 0;
        OnTimerEnd?.Invoke();
    }

    public void Pause()
    {
        this.isPaused = true;
    }

    public void Start()
    {
        this.isPaused = false;
    }

    public void ResetTimer()
    {
        timer = startTime;
    }

}
