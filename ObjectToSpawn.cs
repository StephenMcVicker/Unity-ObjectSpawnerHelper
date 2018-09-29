using UnityEngine;

[System.Serializable]
public class ObjectToSpawn
{

    public string fileLocation; // Files must be in a "Resources" fold. You can have sub folders. Eg. "Prefabs/SuperEffect"
    public GameObject prefabToSpawn;
    public string nameOfGameObject;
    public Transform parent;
    public Vector3 scale;
    public Vector3 pos;

    [Space]
    public bool matchPlayersYValue = false;
    public bool offsetXPosToPlayers = false; // this will add/subtract the pos.x value with the players

    public GameObject obj;
    public void Spawn()
    {
        // Spawn in the prefab
        if (fileLocation.Length >= 1)
        {
            obj = GameObject.Instantiate(Resources.Load(fileLocation), Vector3.zero, Quaternion.identity) as GameObject;
        }
        else if (prefabToSpawn != null)
        {
            obj = GameObject.Instantiate(prefabToSpawn, Vector3.zero, Quaternion.identity) as GameObject;
        }
        else
        {
            Debug.LogWarning("No file location or Gameobject was set in ObjToSpawn");
        }
        obj.name = nameOfGameObject;
        if (parent != null)
        {
            obj.transform.SetParent(parent);
        }

        if (Mathf.Approximately(scale.x, 0f) && Mathf.Approximately(scale.y, 0f) && Mathf.Approximately(scale.z, 0f))
        {
            //Debug.Log("Scale was at 0 for all values.");
            // Don't override values from prefab
        }
        else
        {
            obj.transform.localScale = scale;
        }

        // Reset the general position to 0
        obj.transform.position = Vector3.zero;

		// Use the local position
        obj.transform.localPosition = pos;

    }
}