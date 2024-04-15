using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ColliderZaSmrt : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}