using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int numbertospawn;
    public GameObject toSpawn;
    public GameObject quad;
    
    // Start is called before the first frame update
    void Start()
    {
        numbertospawn = Random.Range(5, 10);
        spawnObjects();
    }

    public void spawnObjects()
    {
        MeshCollider c = quad.GetComponent<MeshCollider>();
        float screenX, screenY;
        Vector2 pos;
        for(int i = 0; i < numbertospawn; i++)
        {
            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
}
