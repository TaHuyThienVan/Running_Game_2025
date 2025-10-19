using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabsToSpawn = new List<GameObject>();

    void Start()
    {
        foreach (GameObject prefab in prefabsToSpawn)
        {
            if (prefab == null)
            {
                Debug.Log("SpawnManager: có prefab null trong danh sách!");
                continue;
            }

            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
