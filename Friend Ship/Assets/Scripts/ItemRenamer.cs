using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRenamer : MonoBehaviour {

    public string itemName;

    public bool connected;
    public GameObject player;

	// Use this for initialization
	void Start () {
        this.gameObject.name = itemName;
	}

    private void Update()
    {
        if(connected == true)
        {
            this.gameObject.transform.position = this.gameObject.transform.parent.position + new Vector3(0, 2, 0);
        }
    }
}
