using UnityEngine;
using UnityEngine.InputSystem;

public class Barrel : MonoBehaviour
{
    public float currentRotation = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 barrelAngle = mousePos - transform.position;

        transform.up = barrelAngle;

        currentRotation = transform.eulerAngles.z;
    }


}
