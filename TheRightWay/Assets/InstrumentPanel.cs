﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;


public class InstrumentPanel : MonoBehaviour {

	public Machine machine;
	public GameObject dial;
	public List<PanelButton> buttons;
	public float lerpTime;

	public void Awake()
	{

	}

	IEnumerator LerpDial( Vector3 pos)
	{
		float timer = 0;
		Vector3 startUp = dial.transform.up;
		Vector3 newUp = (pos - dial.transform.position).normalized;

		while (timer < lerpTime) 
		{
			timer += Time.deltaTime;
			dial.transform.up = Vector3.Lerp(startUp, newUp, timer / lerpTime);
			yield return null;
		}

	}


	public void NotifyHighlight( int index )
	{
		var buttonPos = buttons [index].transform.position;
		StartCoroutine (LerpDial ( buttonPos));
	}


	public void NotifyClick( int index )
	{
		machine.ChangeState (index);

		for (int i = 0; i < buttons.Count; i++) {
			var butt = buttons [i];
			var image = butt.GetComponent<Image>();


			if (i == index) {
				butt.SetActivatedImage (true);

			} else {

				butt.SetActivatedImage (false);
			}	
		}
	}
}
