using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatArrow : MonoBehaviour {

    public GameObject boatMarker;
	
	// Update is called once per frame
	void Update () {
        Vector3 _dir = boatMarker.transform.position;
        _dir.z = 0;

        transform.LookAt(transform.position + transform.forward, _dir - transform.position);
	}
}
