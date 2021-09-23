using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shield : MonoBehaviour
{
    public UnityEvent knifeHitEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Knife>())
        {
            collision.gameObject.GetComponent<Destroyable>().destroy();
            knifeHitEvent?.Invoke();
        }

    }
}
