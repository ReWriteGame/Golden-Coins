using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeBetweenCallsChangedTimeEvent = 1;
    [SerializeField] private bool startOnAwake = true;
    [SerializeField] private bool directionMin = true;

    [SerializeField] private float minTime = 0;
    [SerializeField] private float maxTime = 10;
    [SerializeField] private float currentTime = 0;

    public UnityEvent startTimeEvent;
    public UnityEvent pauseTimeEvent;
    public UnityEvent stopTimeEvent;
    public UnityEvent isMinTimeEvent;
    public UnityEvent isMaxTimeEvent;
    public UnityEvent changedTimeEvent;

    private Coroutine activeTimerLinkCor = null;

    private void Start()
    {
        if(startOnAwake) StartTime();
    }

    public void StartTime()
    {
        StopTime();
        activeTimerLinkCor = StartCoroutine(TimerCor());
    }

    public void StopTime()
    {
        StopCoroutine(activeTimerLinkCor);
    }

    public void PauseTime()
    {

    }

    public void AddTime(float value)
    {
        if (value < 0) return;
        currentTime = (currentTime + value) >= maxTime ? maxTime : (currentTime + value);
        TimeIsMax();
    }

    public void TakeAwayTime(float value)
    {
        if (value < 0) return;
        currentTime = (currentTime - value) <= minTime ? minTime : (currentTime - value);
        TimeIsMin();
    }


    public bool TimeIsMin()
    {
        if (currentTime == minTime) isMinTimeEvent?.Invoke();
        return currentTime == minTime;
    }
    public bool TimeIsMax()
    {
        if (currentTime == maxTime) isMaxTimeEvent?.Invoke();
        return currentTime == maxTime;
    }

    private IEnumerator TimerCor()
    {
        while (true)
        {
            if (directionMin)
            {
               currentTime = currentTime <= maxTime ? (currentTime + Time.deltaTime) : maxTime;
               if (TimeIsMax()) yield break;
            }
            else
            {
                currentTime = currentTime >= minTime ? (currentTime - Time.deltaTime) : minTime;
                if (TimeIsMin()) yield break;
            }
            yield return null;// pause on 1 frame
        }
        yield break;
    }


    


}
