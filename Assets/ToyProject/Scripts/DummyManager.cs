using UnityEngine;
using UnityEngine.UI;

public class DummyManager : MonoBehaviour
{
    // Variables 
    public GameObject characterPrefab;
    GameObject currentInstance;
    public AudioClip spawnSFX;
    public AudioClip destroySFX;
    public AudioSource audioSource;
    public float timerVariable;
    public Text timerText;
    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
}
