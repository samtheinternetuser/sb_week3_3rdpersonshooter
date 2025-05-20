using UnityEngine;

public class BlobController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public float zRange = 20;
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


/*        #region boundary constraints


        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);

        }
//        if (transform.position.z > zRange)
//        {
//            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
//        }
#endregion
*/

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("animal"))
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