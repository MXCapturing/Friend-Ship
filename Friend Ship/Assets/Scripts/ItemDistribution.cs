using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemSpawn
{
    timber = 0,
    anvil = 1
}

public class ItemDistribution : MonoBehaviour {

    public GameObject cube;
    public ItemSpawn itemSpawn;

    private float timberX; private float timberZ;
    private float timberminX = -18f; private float timbermaxX = 20f;
    private float timberminZ = -74f; private float timbermaxZ = -36f;
    private float timberY = 3.7f;

	// Use this for initialization
	void Start () {
        Spawner();
	}
	
	void Spawner()
    {
        switch (itemSpawn)
        {
            case ItemSpawn.timber:
                for (int i = 0; i < 5; i++)
                {
                   timberX = Random.Range(timberminX, timbermaxX);
                    timberZ = Random.Range(timberminZ, timbermaxZ);
                    Instantiate(cube, new Vector3(timberX, timberY, timberZ), Quaternion.identity);
                }
                break;
        }
    }
}
