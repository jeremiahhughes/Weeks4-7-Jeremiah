using UnityEngine;

public class Toggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public void ToggleTape()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

       //if(gameObject.activeInHierarchy == true)
       // {
       //     gameObject.SetActive(false);
       // }
       //else if(gameObject.activeInHierarchy == false)
       // {
       //     gameObject.SetActive(true);
       // }
    }
}
