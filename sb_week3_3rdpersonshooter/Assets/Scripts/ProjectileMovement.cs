using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    public float projectileSpeed = 15.123f;

    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);


    }


}
