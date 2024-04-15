using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenjanjeScena : MonoBehaviour
{
    public void Menjaj(int sceneID)
    {
        SceneManager.LoadScene(1);
    }
}
