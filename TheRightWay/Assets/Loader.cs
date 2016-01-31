using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Loader : MonoBehaviour {

	public string baseScene;

	// Use this for initialization
	void Start () {
		if (!SceneManager.GetSceneByName (baseScene).isLoaded) {
			
			SceneManager.LoadScene (baseScene, LoadSceneMode.Additive);
		}
	}
	

}
