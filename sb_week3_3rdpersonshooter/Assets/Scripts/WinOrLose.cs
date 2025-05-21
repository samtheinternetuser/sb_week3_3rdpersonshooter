using UnityEngine;
using UnityEngine.SceneManagement;
public class WinOrLose : MonoBehaviour
{
    public GameObject blob;
    public float shrinkLimit = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] animals = GameObject.FindGameObjectsWithTag("animal");
        GameObject[] humans = GameObject.FindGameObjectsWithTag("Player");
        int totalAnimals = animals.Length + humans.Length;

        if (totalAnimals == 0)
        {
            SceneManager.LoadScene("blobwin");
        }

        if (blob.transform.localScale.x < shrinkLimit)
        {
            SceneManager.LoadScene("humanwin");
        }


    }
}
