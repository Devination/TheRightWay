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

		if (c.gameObject == floor || c.gameObject.name == "weight" ) {
			killing = false;
			if( projector )
				Destroy (projector);
		}

		if (c.gameObject == PlayerNavigator.i.gameObject && killing) {
			if( projector )
				Destroy (projector);
			FindObjectOfType<Murderer> ().KillPlayer ();
		}

	}

}
