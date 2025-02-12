using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodspawn : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public float spawnTime = 2f;
    public float despawnTime = 5f;
    public Vector2 spawnOffset = new Vector2(3f, 0f);


    private void Start()
    {
        
    }

    
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            int row = i / 5;
            int col = i % 5;

            Vector2 spawnPosition = new Vector2(
                (col - 2) * spawnOffset.x,
                (row - 2) * spawnOffset.y
                );
            GameObject food = Instantiate(foodPrefabs[Random.Range(0, foodPrefabs.Length)], spawnPosition, Quaternion.identity );
            Destroy( food, despawnTime);
        }
    }
}
