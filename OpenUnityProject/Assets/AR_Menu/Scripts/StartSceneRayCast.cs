using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneRayCast : MonoBehaviour
{
    public LayerMask layerMask;

    public float holdTime;

    public Image loadingIcon;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
           if (hit.transform.gameObject.GetComponent<SceneSelector>())
            {
                holdTime += Time.deltaTime * 0.4f;

                if (holdTime >= 1f) hit.transform.gameObject.GetComponent<SceneSelector>().StartScene();
            }
        }
        else
        {
            holdTime = 0;
        }

        loadingIcon.fillAmount = holdTime;
    }
}
