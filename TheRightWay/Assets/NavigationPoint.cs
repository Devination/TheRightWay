using UnityEngine;
using System.Collections;

public class NavigationPoint : MonoBehaviour {


	void OnMouseDown()	{
		PlayerNavigator.SetTarget (gameObject);
	}

}
