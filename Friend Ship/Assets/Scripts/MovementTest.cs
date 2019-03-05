using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum player
{
    p1,
    p2
}

public class MovementTest : MonoBehaviour {

    public Camera cam;
    public float speed;

    public player pl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (pl)
        {
            case player.p1:
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
                break;
            case player.p2:
                if (Input.GetKey(KeyCode.I))
                {
                    transform.position += cam.transform.forward * speed;
                }
                if (Input.GetKey(KeyCode.K))
                {
                    transform.position -= cam.transform.forward * speed;
                }
                if (Input.GetKey(KeyCode.J))
                {
                    transform.position -= cam.transform.right * speed;
                }
                if (Input.GetKey(KeyCode.L))
                {
                    transform.position += cam.transform.right * speed;
                }
                break;
        }
    }
}
