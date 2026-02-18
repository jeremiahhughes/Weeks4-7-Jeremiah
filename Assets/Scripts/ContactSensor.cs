using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent onEnterSensor;
    public UnityEvent onExitSensor;
    public UnityEvent<float> OnRandomNumber;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hazard.bounds.Contains(transform.position) == true)
        {
            if(isInHazard == true)
            {

            }
            else
            {
                //entered the hazard
                Debug.Log("Entered the hazard!");
                onEnterSensor.Invoke();
                isInHazard = true;
            }
               
        }
        else
        {
            if (isInHazard == true)
            {
                // exited the hazard
                Debug.Log("Exited the hazard!");
                onExitSensor.Invoke();
                isInHazard = false;
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
            else
            {
                // still outisde the hazard
            }
        }
    }
    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
