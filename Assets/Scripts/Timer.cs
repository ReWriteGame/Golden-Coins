using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent startTimeEvent;
    public UnityEvent pauseTimeEvent;
    public UnityEvent stopTimeEvent;
    public UnityEvent isMinTimeEvent;
    public UnityEvent isMaxTimeEvent;
    public UnityEvent changedTimeEvent;

    [SerializeField] private float timeBetweenCallsChangedTimeEvent = 1;
    [SerializeField] private bool startOnAwake = true;

    [SerializeField] private float minTime = 0;
    [SerializeField] private float maxTime = 10;
    [SerializeField] private float currentTime = 0;

    private void Start()
    {
        StartTime();
    }
    public void StartTime()
    {
        StartCoroutine(TimerCor());
    }
    public void StopTime()
    {

    }
    public void PauseTime()
    {

    }

    public void AddTime()
    {

    }

    public void TakeAwayTime()
    {

    }

    private IEnumerator TimerCor()
    {
        /*float duration = 3f; // 3 seconds you can change this 
                             //to whatever you want
        float normalizedTime = 0;
        while (normalizedTime <= 1f)
        {
            normalizedTime += Time.deltaTime / duration;
            yield return null;
        }*/

        for (float time = 0; time <= maxTime;)
        {
            currentTime += Time.deltaTime;
            time += Time.deltaTime;
            yield return null;
        }
        currentTime = maxTime;




        yield break;
    }



    void Update()
    {
        
    }


}
