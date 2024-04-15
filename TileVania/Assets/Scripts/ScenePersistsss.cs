using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersistsss : MonoBehaviour
{
    void Awake() {
        int numScenePersists = FindObjectsOfType<ScenePersistsss>().Length;
        if (numScenePersists > 1)
        {
            Destroy(gameObject);
        }
        else 
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
