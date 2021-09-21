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

    [SerializeField] private int minTime = 0;
    [SerializeField] private int maxTime;
    [SerializeField] private int currentTime;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
