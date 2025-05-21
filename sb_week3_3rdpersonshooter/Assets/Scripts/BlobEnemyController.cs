using UnityEngine;

public class BlobEnemyController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xLowerBound = -20;
    public float xUpperBound = 179;
    public float zLowerBound = -10;
    public float zUpperBound = 204;
    public float growthrate = 1.2f;
    public float shrinkrate = 0.8f;
    public Vector3 moveDirection;
    public Transform target;

    void Start()
    {
        // Optional: Initialization
    }

    void Update()
    {
        // Get closest animal OR human
        target = FindClosestAnimalOrHuman();

        if (target != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.position,
                speed * Time.deltaTime
            );
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

    Transform FindClosestTargetWithTag(string tag)
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(tag);
        GameObject closest = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject obj in targets)
        {
            float distance = Vector3.Distance(transform.position, obj.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = obj;
            }
        }

        return closest != null ? closest.transform : null;
    }

    Transform FindClosestAnimalOrHuman()
    {
        GameObject[] animals = GameObject.FindGameObjectsWithTag("animal");
        GameObject[] humans = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] allTargets = new GameObject[animals.Length + humans.Length];

        animals.CopyTo(allTargets, 0);
        humans.CopyTo(allTargets, animals.Length);

        GameObject closest = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject obj in allTargets)
        {
            float distance = Vector3.Distance(transform.position, obj.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = obj;
            }
        }

        return closest != null ? closest.transform : null;
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
