using UnityEngine;

public class SpawnChunk : VanMonoBeha
{
    [SerializeField] private SpawnManager spawnManager;
    [Header("Chunk")]

    public float chunkLength = 10f;
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] Transform chunkParent;
    [SerializeField] int startingChunk = 10;

    void Start()
    {
        SpawnManager.instance.SpawnChunk(chunkPrefab,chunkParent,startingChunk,chunkLength);
    }

    
}
