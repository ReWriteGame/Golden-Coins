using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeGun : MonoBehaviour
{
    public Transform directionThrow;

    [SerializeField] private Knife currentKnife;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Knife>())
            currentKnife = collision.GetComponent<Knife>();
    }

    
    public void ThrowKnife()
    {
        currentKnife.gameObject.GetComponent<Rigidbody2D>().AddForce((directionThrow.position - transform.position).normalized * currentKnife.Force, ForceMode2D.Impulse);
    }
}
