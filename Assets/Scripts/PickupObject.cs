using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public Timer timerScript; // Reference to the Timer script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the AddTime function on the Timer script
            if (timerScript != null)
            {
                timerScript.AddTime(30f); // Adjust the timeToAdd value as needed
                Debug.Log("Time Added by PickupObject script: " + 30f);
            }

            Destroy(gameObject);
        }
    }
}