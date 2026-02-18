using UnityEngine;

public class Boulder : MonoBehaviour
{
    public float speed = 3f;
    public GameObject boulderPrefab;
    public SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = transform.position;
        newPos += transform.right * speed * Time.deltaTime;
        transform.position = newPos;
    }
    public void SpawnBoulder()
    {
       Instantiate(boulderPrefab, transform.position, Quaternion.identity);
        sr = GetComponent<SpriteRenderer>();
    }
    public void Destroy()
    {
        Destroy(boulderPrefab);
    }
}
