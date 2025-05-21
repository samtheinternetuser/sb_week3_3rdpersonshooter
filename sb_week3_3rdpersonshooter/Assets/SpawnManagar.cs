using UnityEngine;

public class SpawnManagar : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;

    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;

    public animalInfo[] animalInformation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(animalInformation[2].animalName);
        }
        if (Input.GetKeyDown(KeyCode.L))
            {


                Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(spawnRangeZ, -spawnRangeZ));
                int animalIndex = Random.Range(0, animalPrefabs.Length);
                Instantiate(animalPrefabs[animalIndex], spawnPos,
                Quaternion.Euler(0, Random.Range(0, 360), 0));
            } 
        
    }
}

[System.Serializable]
public struct animalInfo
{
    public GameObject animalPrefab;
    public string animalName;
    public bool isHostile;
}