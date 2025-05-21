using UnityEngine;
using UnityEngine.SceneManagement;

public class BlobController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    
    public float xLowerBound = -20;
    public float xUpperBound = 179;
    public float zLowerBound = -10;
    public float zUpperBound = 204;
    public float growthrate = 1.2f;
    public float shrinkrate = 0.8f;
    public Vector3 spawnOffset;
    public Vector3 moveDirection;
    void Start()
    {

    }

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal1");
        float verticalInput = Input.GetAxis("Vertical1");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        transform.Translate(moveDirection * speed * Time.deltaTime * -1);


        #region boundary constraints


        if (transform.position.x < xLowerBound)
        {
            transform.position = new Vector3(xLowerBound, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xUpperBound)
        {
            transform.position = new Vector3(xUpperBound, transform.position.y, transform.position.z);

        }

        if (transform.position.z < zLowerBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zLowerBound);

        }
        if (transform.position.z > zUpperBound)

        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zUpperBound);
        }
        #endregion




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