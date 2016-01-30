using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;


public class PanelButton : Button {

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
