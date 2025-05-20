using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    public float animalSpeed = 10;
    public float animalgrow = 1.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * animalSpeed * Time.deltaTime);
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            transform.Rotate(0, 180, 0);
        }

        else if (other.CompareTag("veg"))
        {
            transform.localScale = transform.localScale * animalgrow;
            other.gameObject.SetActive(false);

            
            
        }
    }
}
