using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    public SpriteRenderer sr;
    public float speed;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.wholeNumbers = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }

    public void ChangeColor()
    {
        sr.color = Random.ColorHSV();
    }

    public void StartRotateAlien(float speed)
    {
        speed = 100;
    }

    
}
