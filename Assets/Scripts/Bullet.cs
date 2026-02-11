using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        //newPos.y += speed * Time.deltaTime;
        //newPos.x += speed * Time.deltaTime;
        newPos += transform.up * speed * Time.deltaTime;
        transform.position = newPos;    
        
    }
}
