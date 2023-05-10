using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public string sceneName;

    public void StartScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
