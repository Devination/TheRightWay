using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;


public class PanelButton : Button {

	public bool composite;


	public void SetActivatedImage( bool state )
	{
		var icons = GetComponent<Icons> ();


		if (!icons.composite) {
			

			var image = GetComponent<Image> ();

			if (state) {
				image.sprite = icons.selected;	
			} else {

				image.sprite = icons.unselected;
			}
		} else {
			var image = transform.FindChild ("Image").GetComponent<Image> ();

			if (state) {
				image.color = Color.red;
			} else {
				image.color = Color.black;
			}

		}
	}


	public override void OnPointerEnter (UnityEngine.EventSystems.PointerEventData eventData)
	{
		var panel = GetComponentInParent<InstrumentPanel> ();

		int index = panel.buttons.IndexOf (this);
		panel.NotifyHighlight (index);
		base.OnPointerEnter (eventData);

	}


	public override void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData)
	{
		var panel = GetComponentInParent<InstrumentPanel> ();
		int index = panel.buttons.IndexOf (this);
		panel.NotifyClick (index);
		base.OnPointerClick (eventData);

	}
}
