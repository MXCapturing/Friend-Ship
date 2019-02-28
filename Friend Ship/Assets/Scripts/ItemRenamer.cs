using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRenamer : MonoBehaviour {

    public string itemName;
    private Collider _col;
    private Rigidbody _rb;

    public bool connected;
    public GameObject player;

	// Use this for initialization
	void Start () {
        _col = this.gameObject.GetComponent<Collider>();
        _rb = this.gameObject.GetComponent<Rigidbody>();
        this.gameObject.name = itemName;
        Invoke("MakeTrigger", 2);
	}

    private void Update()
    {
        if(connected == true)
        {
            this.gameObject.transform.position = this.gameObject.transform.parent.position + new Vector3(0, 2, 0);
        }
    }

    private void MakeTrigger()
    {
        _rb.useGravity = false;
        _col.isTrigger = true;
        _rb.velocity = Vector3.zero;
        _rb.angularVelocity = Vector3.zero;
    }
}
