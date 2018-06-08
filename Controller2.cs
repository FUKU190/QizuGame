using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour {
    public float Nomalspeed,Highspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal") * Nomalspeed;
        float z = Input.GetAxis("Vertical") * Nomalspeed;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // xとyにspeedを掛ける
        rigidbody.AddForce(x * Nomalspeed, 0, z * Nomalspeed);
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {

        }
    }
}
