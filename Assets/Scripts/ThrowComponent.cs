using UnityEngine;
using System.Collections;

public class ThrowComponent : MonoBehaviour {

    public GameObject Bird;
    public float BirdVelocity = 15.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonUp("Fire1"))
        {
            //Debug.Log("Fire~");
            GameObject newObj = Instantiate(Bird) as GameObject;
            newObj.GetComponent<Rigidbody>().position = transform.position;
            newObj.GetComponent<Rigidbody>().velocity = transform.forward * BirdVelocity;
            
            Destroy(newObj, 3f);
        }
	}
}
