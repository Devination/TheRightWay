using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;


public class InstrumentPanel : MonoBehaviour {

	public Machine machine;
	public GameObject dial;
	public List<PanelButton> buttons;


	public void Awake()
	{
		buttons = new List<PanelButton> ();

	}

	IEnumerator LerpDial()
	{


	}


	public void NotifyHighlight( int index )
	{


	}


	public void NotifyClick( int index )
	{


	}


}
