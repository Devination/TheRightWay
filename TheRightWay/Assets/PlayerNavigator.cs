using UnityEngine;
using System.Collections;

public class PlayerNavigator : MonoBehaviour {

	public static PlayerNavigator i;
	public GameObject navSparklesPrefab;
	public float completionDistance;
	GameObject sparkles;
	bool oneFrameDelay = false;

	public static void SetTarget( GameObject go )
	{
		i.NavigateToPoint( go.transform.position);
	}

	public NavMeshAgent navAgent;

	public void NavigateToPoint( Vector3 targetPos )
	{
		if (!sparkles) {
			sparkles = Instantiate (navSparklesPrefab);	
		}
		sparkles.transform.position = targetPos;	
		navAgent.destination = targetPos;
		oneFrameDelay = true;
	}

	void Awake()
	{
		i = this;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (navAgent.remainingDistance < completionDistance && sparkles && !oneFrameDelay) 
		{
			Destroy (sparkles);
			sparkles = null;

		}
		oneFrameDelay = false;
	}
}
