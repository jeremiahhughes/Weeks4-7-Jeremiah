using UnityEngine;
using UnityEngine.UI;

public class DummyManager : MonoBehaviour
{
    // Variables 
    public GameObject characterPrefab;
    GameObject currentInstance;
    // Audio Clips
    public AudioClip spawnSFX;
    public AudioClip destroySFX;
    public AudioSource audioSource;
    // for time played text
    public float timerVariable;
    public Text timerText;
    // using private spriterenderer 
    private SpriteRenderer sr;
    // Y position variable for the slider
    private float currentYPosition;
    // Rotating variable
    private bool isRotating = false;
    // sliders
    public Slider positionSlider;
    public Slider scaleSlider;
    public Slider rotationSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // setting min and max values of the sliders at the start 
        positionSlider.minValue = -4f;
        positionSlider.maxValue = 4f;

        scaleSlider.minValue = 1f;
        scaleSlider.maxValue = 3f;

        rotationSlider.minValue = 0f;
        rotationSlider.maxValue = 360f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCharacter ()
    {
        // Check to spawn if the character does not already exist in the scene
        if(currentInstance == null)
        {
            currentInstance = Instantiate(characterPrefab, Vector3.zero, Quaternion.identity);
            // using GetComponent to get the spriterenderer instead of having a public variable reference
            sr = currentInstance.GetComponent<SpriteRenderer>();
            audioSource.PlayOneShot(spawnSFX); // plays the spawn audio clip
        }
    }
    public void DestroyCharacter()
    {
        //check to destroy if the character exists in the scene
        if(currentInstance != null)
        {
            audioSource.PlayOneShot(destroySFX); // plays the destroy audio clip 
            Destroy(currentInstance);
            currentInstance = null;
        }
    }
    public void SetColorBlue()
    {
        // Change color only if sr is not null
        if(sr  != null)
        {
            sr.color = Color.blue;
        }
        
    }
    public void SetColorRed()
    {
        // Change color only if sr is not null
        if (sr != null)
        {
            sr.color = Color.red;
        }
    }
    public void SetColorRandom()
    {
        // Change color only if sr is not null
        if (sr != null)
        {
            sr.color = Random.ColorHSV();
        }
    }
    public void SetScale(float scale) // got this function from required reading 5-1 Sliders at timestamp 6:28
    {
        currentInstance.transform.localScale = Vector3.one * scale;
    }
    public void SetYPosition(float yValue)
    {
        currentInstance.transform.position = new Vector3(0, yValue, 0);
    }
    public void SetRotation(float angle)
    {
        currentInstance.transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
