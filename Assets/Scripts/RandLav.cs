using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public string folderName = "ObjectsFolder"; // Change this to the name of your folder
    public Material spawnMaterial;
    public GameObject spawnPositionObject;

    private GameObject[] objectsToSpawn;

    void Start()
    {
        LoadObjectsFromFolder();

        // Check if there are objects to spawn
        if (objectsToSpawn.Length > 0)
        {
            // Generate a random index to select an object from the array
            int randomIndex = Random.Range(0, objectsToSpawn.Length);

            // Get the spawn position
            Vector3 spawnPosition = spawnPositionObject.transform.position;

            // Spawn the selected object at the spawner's position with rotation
            GameObject spawnedObject = Instantiate(objectsToSpawn[randomIndex], spawnPosition, Quaternion.Euler(-90, -180, 0));

            // Add a MeshCollider to the spawned object
            MeshCollider meshCollider = spawnedObject.AddComponent<MeshCollider>();

            // Set the material
            Renderer renderer = spawnedObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = spawnMaterial;
            }

            // Set the object size
            spawnedObject.transform.localScale = new Vector3(12000, 12000, 12000);
        }
        else
        {
            Debug.LogError("No objects to spawn. Make sure objects are placed in the folder and assigned to the 'objectsToSpawn' array in the inspector.");
        }
    }

    void LoadObjectsFromFolder()
    {
        // Load objects from the specified folder
        Object[] loadedObjects = Resources.LoadAll(folderName, typeof(GameObject));

        // Convert loaded objects to GameObject array
        objectsToSpawn = new GameObject[loadedObjects.Length];
        for (int i = 0; i < loadedObjects.Length; i++)
        {
            objectsToSpawn[i] = (GameObject)loadedObjects[i];
        }
    }
}