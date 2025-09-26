using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Array of animal prefabs to spawn
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        // Start repeatedly spawning animals after a delay
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Spawns a random animal at a random X position
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation
        );
    }
}
