using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodspawn : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public float spawnTime = 20.5f;
    public float despawnTime = 20f;
    public Vector2 spawnOffset = new Vector2(3f, 3f);

    private float timer = 0f;
    public GameObject[] activateFood = new GameObject[4];
    private Color normalColor = new Color(1f, 1f, 1f); //normal


    private void Start()
    {
        SpawnFood();
    }


    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            SpawnFood();
            timer = 0f;
        }
    }
    void SpawnFood()
    {
        for (int i = 0; i < activateFood.Length; i++)
        {
            if (activateFood[i] != null)
            {
                Destroy(activateFood[i]);
            }
        }
            for (int i =0; i <4;  i++)
        {
                 Vector2 spawnPosition = new Vector2(
                (i - 1) * spawnOffset.x, 0
                );

            if (foodPrefabs.Length > 0)
            {
                GameObject food = Instantiate(foodPrefabs[Random.Range(0, foodPrefabs.Length)], 
                    spawnPosition, Quaternion.identity);
                SpriteRenderer sr = food.GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    sr.color = normalColor;
                }
                activateFood[i] = food;
                Destroy(food, despawnTime);
            }
        } 
        }
            
    }

// changed 2 rows of 5, to 1 row of 4 since when I distort screens width the prefabs dont look nice :(