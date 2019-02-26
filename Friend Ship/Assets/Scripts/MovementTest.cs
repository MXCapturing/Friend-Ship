using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {

    public Camera cam;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += cam.transform.forward * speed; 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= cam.transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= cam.transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += cam.transform.right * speed;
        }
    }
}
