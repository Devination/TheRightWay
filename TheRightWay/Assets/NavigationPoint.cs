using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NavigationPoint : MonoBehaviour {

	public GameObject navObject;

	void OnMouseDown()	{
		bool overUI = EventSystem.current.IsPointerOverGameObject ();
		if (overUI)
			return;

		PlayerNavigator.SetTarget (navObject);
	}

}
