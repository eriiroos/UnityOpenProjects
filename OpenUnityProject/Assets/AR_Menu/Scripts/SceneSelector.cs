using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public string sceneName;

    public BoxCollider collider;

    private void Start()
    {
        collider.enabled = false;

        StartCoroutine(EnableCollider());
    }

    //to avoid starting issue enable the collider after time
    IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(3f);

        collider.enabled = true;
    }

    public void StartScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
