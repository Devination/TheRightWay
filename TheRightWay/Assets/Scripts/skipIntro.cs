using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class skipIntro : MonoBehaviour {

    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("KELLY JELLY SCENE");
        }
    }
}

// Update is called once per frame

