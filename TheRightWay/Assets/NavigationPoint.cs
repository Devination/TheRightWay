using UnityEngine;
using System.Collections;

public class NavigationPoint : MonoBehaviour {

	public GameObject navObject;

	void OnMouseDown()	{
		PlayerNavigator.SetTarget (navObject);
	}

}
