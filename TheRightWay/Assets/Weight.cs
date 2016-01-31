using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour {

	public bool killing;
	public GameObject projector;

	GameObject floor;

	// Use this for initialization
	void Start () {
	
		floor = FindObjectOfType<FloorNavigation> ().gameObject;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter( Collision c )
	{

		if (c.gameObject == floor) {
			killing = false;
			Destroy (projector);
		}

		if (c.gameObject == PlayerNavigator.i.gameObject && killing) {
			FindObjectOfType<Murderer> ().KillPlayer ();
		}

	}

}
