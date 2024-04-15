using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class izlaz : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}