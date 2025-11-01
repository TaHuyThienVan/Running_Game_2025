using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    


    void Start()
    {
    
                      
    }

    public void SpawnChunk(GameObject prefab, Transform parent , int starting, float chunkLength)
    {

        for (int i = 0; i < starting; i++)
        {
            float spawnPositionZ;
            if (i == 0) spawnPositionZ = transform.position.z;
            else spawnPositionZ = transform.position.z + (i * chunkLength);

            Vector3 chunkSpawnPos = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);

            Instantiate(prefab, chunkSpawnPos, Quaternion.identity,parent);
        }
    }
}
