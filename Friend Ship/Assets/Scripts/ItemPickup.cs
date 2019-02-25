using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public static ItemPickup instance;

    public List<GameObject> invItem = new List<GameObject>();

    private void Start()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item" && invItem.Count < 1)
        {
            invItem.Add(other.gameObject);
            other.gameObject.transform.parent = this.gameObject.transform;
            other.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0,2,0);
        }
    }
}
