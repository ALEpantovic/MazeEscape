using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerupPrefab;  // Assign the powerup prefab in the Inspector
    public Transform spawnTarget;     // Assign the spawner object

    public int numberOfObjectsToSpawn = 100;  // Number of objects to spawn
    public float spawnRadius = 5f;           // Radius around the spawner for scattering

    void Start()
    {
        GetComponent<Renderer>().enabled = false;
        // Spawn objects with scatter pattern
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            SpawnPowerupScattered();
        }
    }

    void SpawnPowerupScattered()
    {
        // Generate a random position within the spawn radius
        Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
        randomPosition.y = 0;
        randomPosition = spawnTarget.position + randomPosition;  // Offset from spawner's position

        // Rotate the powerup randomly
        Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

        // Instantiate the powerup at the scattered position and rotation
        Instantiate(powerupPrefab, randomPosition, randomRotation);
    }
}