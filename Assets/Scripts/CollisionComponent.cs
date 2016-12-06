using UnityEngine;
using System.Collections;

public class CollisionComponent : MonoBehaviour {

    public AudioClip collisionSound;

    void OnCollisionEnter(Collision target)
    {   
        if (target.relativeVelocity.magnitude > 5   )
        {
            Debug.Log("我撞到惹");

            GetComponent<AudioSource>().PlayOneShot(collisionSound);
        }
    }
}
