using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public float zRange = 20;
    public float growthrate = 4;

    void Start()
    {

    }

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }


        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);

        }
//        if (transform.position.z > zRange)
//        {
//            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
//        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("animal"))
        {
            transform.localScale = transform.localScale * growthrate;
            other.gameObject.SetActive(false);
        }
    }
}