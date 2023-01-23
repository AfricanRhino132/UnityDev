using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    [SerializeField] private string hitTag = string.Empty;

    public delegate void CollisionEvent(GameObject other);
    public CollisionEvent onEnter;
    public CollisionEvent onExit;
    public CollisionEvent onStay;

    private void OnCollisionEnter(Collision collision)
    {
        if (hitTag == string.Empty || collision.gameObject.CompareTag(hitTag))
        {
            onEnter?.Invoke(collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (hitTag == string.Empty || collision.gameObject.CompareTag(hitTag))
        {
            onExit?.Invoke(collision.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (hitTag == string.Empty || collision.gameObject.CompareTag(hitTag))
        {
            onStay?.Invoke(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hitTag == string.Empty || other.gameObject.CompareTag(hitTag))
        {
            onEnter?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (hitTag == string.Empty || other.gameObject.CompareTag(hitTag))
        {
            onExit?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (hitTag == string.Empty || other.gameObject.CompareTag(hitTag))
        {
            onStay?.Invoke(other.gameObject);
        }
    }


}
