using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;


public class PanelButton : Button {


	public void SetActivatedImage( bool state )
	{
		var icons = GetComponent<Icons> ();
		var image = GetComponent<Image> ();

		if (state) {
			image.sprite = icons.selected;	
		} else {

			image.sprite = icons.unselected;
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
