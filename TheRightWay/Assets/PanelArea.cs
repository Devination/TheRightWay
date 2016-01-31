using UnityEngine;
using System.Collections;

public class PanelArea : MonoBehaviour {

	public GameObject panel;

	void OnTriggerEnter( Collider c )
	{
		if (c.gameObject.name != "weight")
			panel.SetActive (true);
	}

	void OnTriggerExit()
	{
		if (c.gameObject.name != "weight")
			panel.SetActive (false);
	}

}
