using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    public float speed = 10.0f;
    public float xRange = 20;
    public float zRange = 20;
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

/*
        #region boundary constraints


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



}