using UnityEngine;
using System.Collections;

public class PlayerNavigator : MonoBehaviour {

	public static PlayerNavigator i;

	public static void SetTarget( GameObject go )
	{
		i.NavigateToPoint( go.transform.position);
	}

	public NavMeshAgent navAgent;

	public void NavigateToPoint( Vector3 targetPos )
	{
		navAgent.destination = targetPos;
	}

	void Awake()
	{
		i = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
