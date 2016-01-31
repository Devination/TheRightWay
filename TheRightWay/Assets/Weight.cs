using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour {

	public float fallSpeed;
	public bool killing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if( killing )
			transform.position = transform.position + Vector3.down * fallSpeed * Time.deltaTime;


	}

	void OnCollisionEnter( Collision c )
	{
		if (c.gameObject.layer == 1 << LayerMask.NameToLayer ("Floor")) {

			killing = false;

		} else if (c.gameObject == PlayerNavigator.i.gameObject) {
			// kill
		}

	}

}
