using UnityEngine;
using System.Collections;

public class PanelArea : MonoBehaviour {

	public GameObject panel;

	void OnTriggerEnter()
	{
		panel.SetActive (true);
	}

	void OnTriggerExit()
	{
		panel.SetActive (false);
	}

}
