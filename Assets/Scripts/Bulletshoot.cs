using UnityEngine;
using UnityEngine.InputSystem;

public class Bulletshoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed = 3;
    public float currentRotation = 0;
    public AudioSource shootSFX;
    public AudioClip shootSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Debug.Log("You shot a bullet!");
            PlaySFX();
        }
    }
    public void PlaySFX()
    {
       shootSFX.clip = shootSound;
       shootSFX.Play();
    }
}
