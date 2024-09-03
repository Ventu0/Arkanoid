using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanceDePoder : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    public float powerUpChance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TrySpawnPowerUp(Vector2 position)
    {
        if (Random.value <= powerUpChance)
        {
            int randomIndex = Random.Range(0, powerUpPrefabs.Length);
            GameObject powerUp = Instantiate(powerUpPrefabs[randomIndex], position, Quaternion.identity);
            Debug.Log("Power-Up Spawned: " + powerUp.name);
        }
    }
}
