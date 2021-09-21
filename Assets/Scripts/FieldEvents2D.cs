using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class FieldEvents2D : MonoBehaviour
{
    public UnityEvent CollisionEnterEvent;
    public UnityEvent CollisionStayEvent;
    public UnityEvent CollisionExitEvent;

    public UnityEvent TriggerEnterEvent;
    public UnityEvent TriggerStayEvent;
    public UnityEvent TriggerExitEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CollisionEnterEvent?.Invoke();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        CollisionStayEvent?.Invoke();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        CollisionExitEvent?.Invoke();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerEnterEvent?.Invoke();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        TriggerStayEvent?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TriggerExitEvent?.Invoke();
    }
}
