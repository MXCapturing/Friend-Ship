using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemSpawn
{
    timber = 0,
    sewingmachine = 1,
    nails = 2,
    steeringwheel = 3,
    paint = 4,
    flamethrower = 5,
    sand = 6,
    raft = 7,
    fabric = 8
}

public class ItemDistribution : MonoBehaviour {

    public GameObject cube, sewing, nails, steeringWheel, paint, flameThrower, sand, raft, fabric;
    public ItemSpawn itemSpawn;

    private int spawn;

    public Vector3[] timberSpawn, sewingMSpawn, nailSpawn, steeringSpawn, paintSpawn, flameSpawn, sandSpawn, raftSpawn, fabricSpawn;

	// Use this for initialization
	void Start () {
        Spawner();
	}
	
	void Spawner()
    {
        switch (itemSpawn)
        {
            case ItemSpawn.timber:
                spawn = Random.Range(0, timberSpawn.Length);
                for (int i = 0; i < 6; i++)
                {
                    print(spawn);
                    Instantiate(cube, timberSpawn[spawn], Quaternion.identity);
                    spawn++;
                    if (spawn >= timberSpawn.Length)
                    {
                        spawn = 0;
                    }
                }
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.sewingmachine:
                spawn = Random.Range(0, sewingMSpawn.Length);
                Instantiate(sewing, sewingMSpawn[spawn], Quaternion.identity);
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.nails:
                spawn = Random.Range(0, nailSpawn.Length);
                for (int i = 0; i < 6; i++)
                {
                    Instantiate(nails, nailSpawn[spawn], Quaternion.identity);
                    spawn++;
                    if (spawn >= nailSpawn.Length)
                    {
                        spawn = 0;
                    }
                }
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.steeringwheel:
                spawn = Random.Range(0, steeringSpawn.Length);
                for (int i = 0; i < 4; i++)
                {
                    Instantiate(steeringWheel, steeringSpawn[spawn], Quaternion.identity);
                    spawn++;
                    if (spawn >= steeringSpawn.Length)
                    {
                        spawn = 0;
                    }
                }
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.paint:
                spawn = Random.Range(0, paintSpawn.Length);
                for (int i = 0; i < 2; i++)
                {
                    Instantiate(paint, paintSpawn[spawn], Quaternion.identity);
                    spawn++;
                    if (spawn >= paintSpawn.Length)
                    {
                        spawn = 0;
                    }
                }
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.flamethrower:
                spawn = Random.Range(0, flameSpawn.Length);
                Instantiate(flameThrower, flameSpawn[spawn], Quaternion.identity);
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.sand:
                spawn = Random.Range(0, sandSpawn.Length);
                for (int i = 0; i < 4; i++)
                {
                    Instantiate(sand, sandSpawn[spawn], Quaternion.identity);
                    spawn++;
                    if (spawn >= sandSpawn.Length)
                    {
                        spawn = 0;
                    }
                }
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.raft:
                spawn = Random.Range(0, raftSpawn.Length);
                Instantiate(raft, raftSpawn[spawn], Quaternion.identity);
                itemSpawn++;
                Spawner();
                break;

            case ItemSpawn.fabric:
                spawn = Random.Range(0, fabricSpawn.Length);
                for (int i = 0; i < 2; i++)
                {
                    Instantiate(fabric, fabricSpawn[spawn], Quaternion.identity);
                    spawn++;
                    if (spawn >= fabricSpawn.Length)
                    {
                        spawn = 0;
                    }
                }
                itemSpawn++;
                Spawner();
                break;
        }
    }
}