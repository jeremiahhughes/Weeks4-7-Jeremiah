using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject CapsulePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomSpawn();
    }

    public void randomSpawn()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
         Instantiate(CapsulePrefab);
        }
        
    }
}
