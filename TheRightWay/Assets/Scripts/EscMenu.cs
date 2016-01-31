using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour {

		
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
	}
}
