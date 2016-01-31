using UnityEngine;
using System.Collections;

public class Murderer : MonoBehaviour {

	public int minTime;
	public int maxTime;

	public float weightHeight;
	public float weightSpeed;

	public GameObject weightPrefab;

	public string[] deadStrings = 
	{
		"die!",
		"incompetence!",
		"you're finished!",
	};

	public void Kill()
	{
		var player = FindObjectOfType<PlayerNavigator> ();

		var startPos = player.transform.position + Vector3.up * weightHeight;
		var weight = Instantiate (weightPrefab);
		weight.transform.position = startPos;
		var deadstring = deadStrings [Random.Range (0, deadStrings.Length)];
		BossScript.i.bossSays (deadstring);
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
