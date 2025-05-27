using UnityEngine;

public class CameraController1 : MonoBehaviour
{

    public float zOffset = 10;

    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = new Vector3(player.position.x, (5 + (player.localScale.x * 4)), player.position.z + zOffset + player.localScale.x * 2);
        transform.rotation = Quaternion.Euler((20 + (player.localScale.x * 3)), 180, 0);
    }
}
