using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    public float speed = 10.0f;
    public float xLowerBound = -20;
    public float xUpperBound = 179;
    public float zLowerBound = -10;
    public float zUpperBound = 204;
    public GameObject projectile;
    public Vector3 spawnOffset;
    void Start()
    {

    }

    void Update()
    {

        float horizontalInput1 = Input.GetAxis("Horizontal2");
        float verticalInput1 = Input.GetAxis("Vertical2");
    
        Vector3 moveDirection1 = new Vector3(horizontalInput1, 0, verticalInput1).normalized;

        transform.Translate(moveDirection1 * speed * Time.deltaTime);
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
    Destroy(Instantiate(projectile, transform.position + spawnOffset, projectile.transform.rotation), 5);
//            Instantiate(projectile, transform.position + spawnOffset, projectile.transform.rotation);
        }


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



}