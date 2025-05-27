//THIS IS THE ABORTIVE ATTEMPT AT A SCRIPT FOR THE ENEMY BLOB IN THE SINGLE PLAYER VERSION OF THE GAME

/*

using UnityEngine;

public class BlobEnemyController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xLowerBound = -20;
    public float xUpperBound = 179;
    public float zLowerBound = -10;
    public float zUpperBound = 204;
    public float growthrate = 1.2f;
    public float growthlimit = 20;
    public float shrinkrate = 0.8f;
    public Transform target;
    void Start()
    {

    }

    void Update()
    {
        target = GameObject.FindWithTag("animal");
       transform.position = Vector3.MoveTowards(target);
        //limit size
        if (transform.localScale.x > growthlimit)
        {
            transform.localScale = new Vector3(growthlimit, growthlimit, growthlimit);
        }


        // Boundary constraints
        if (transform.position.x < xLowerBound)
            transform.position = new Vector3(xLowerBound, transform.position.y, transform.position.z);

        if (transform.position.x > xUpperBound)
            transform.position = new Vector3(xUpperBound, transform.position.y, transform.position.z);

        if (transform.position.z < zLowerBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, zLowerBound);

        if (transform.position.z > zUpperBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, zUpperBound);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("animal"))
        {
            transform.localScale = transform.localScale * growthrate;
            other.gameObject.SetActive(false);
        }      
        else if (other.CompareTag("Player"))
        {
            transform.localScale = transform.localScale * growthrate;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("veg"))
        {
            transform.localScale = transform.localScale * shrinkrate;
            other.gameObject.SetActive(false);
        }
    }
}
*/