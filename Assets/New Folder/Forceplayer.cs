using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forceplayer : MonoBehaviour {
	public Rigidbody rb;
	 public float speed;
    public float tilt;
	// Use this for initialization
	void Start () {
		rb=gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
				 
	}
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal*speed, 0.0f, speed).normalized;
		movement = transform.TransformDirection(movement);
        rb.velocity = movement * speed;
        rb.rotation = Quaternion.Euler ( moveVertical * tilt, 0.0f, moveHorizontal * -tilt);
    }

}
// if (Input.GetButton("Fire1"))
// 		 {
// 			 rb.velocity = transform.up * 10;

// 		 }
