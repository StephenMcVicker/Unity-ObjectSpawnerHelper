using UnityEngine;

public class SpawnObjectExample : MonoBehaviour
{
    public ObjectToSpawn objToSpawn;

    void Start()
    {
        // Spawn the object on start for testing
        objToSpawn.Spawn();
    }

}