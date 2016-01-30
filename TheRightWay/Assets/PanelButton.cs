using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;


public class PanelButton : Button {

	public override void OnPointerEnter (UnityEngine.EventSystems.PointerEventData eventData)
	{
		base.OnPointerEnter (eventData);

		var panel = GetComponentInParent<InstrumentPanel> ();

		int index = panel.buttons.IndexOf (this);
		panel.NotifyHighlight (index);
	}


	public override void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData)
	{
		base.OnPointerClick (eventData);

		var panel = GetComponentInParent<InstrumentPanel> ();
		int index = panel.buttons.IndexOf (this);
		panel.NotifyClick (index);
	}

}
