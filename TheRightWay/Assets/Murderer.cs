using UnityEngine;
using System.Collections;

public class Murderer : MonoBehaviour {

	public int minTime;
	public int maxTime;

	public float weightHeight;
	public float weightSpeed;

	public GameObject weightPrefab;



	public void Kill()
	{
		var player = FindObjectOfType<PlayerNavigator> ();


	}


	IEnumerator killRoutine( float killTime )
	{
		yield return new WaitForSeconds (killTime);
		Kill ();
	}

	// Use this for initialization
	void Start () {
	
		float killTime = Random.Range (minTime, maxTime);



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
