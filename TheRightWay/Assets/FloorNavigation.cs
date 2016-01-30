using UnityEngine;
using System.Collections;

public class FloorNavigation : MonoBehaviour {

	public Camera mainCamera;
	public LayerMask floorLayer;

	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown (0)) 
		{
			var screenRay = mainCamera.ScreenPointToRay (Input.mousePosition);
			RaycastHit info;
			if (Physics.Raycast (screenRay, out info, 100, floorLayer)) 
			{
				if( info.transform.gameObject == this.gameObject)
					PlayerNavigator.i.NavigateToPoint (info.point);
			}
		}
	}
}
