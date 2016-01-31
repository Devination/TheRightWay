using UnityEngine;
using System.Collections;

public class Murderer : MonoBehaviour {

	public int minTime;
	public int maxTime;

	public float respawnTime;

	public float weightHeight;
	public float weightSpeed;

	public GameObject weightPrefab;
	public GameObject projectorPrefab;
	public GameObject splatterPrefab;
	public GameObject spawnPoint;

	public string[] deadStrings = 
	{
		"die!",
		"incompetence!",
		"you're finished!",
	};


	IEnumerator WaitToRespawn()
	{
		var player = FindObjectOfType<PlayerNavigator> ();
		player.gameObject.SetActive (false);
		yield return new WaitForSeconds (respawnTime);
		player.gameObject.SetActive (true);
		player.transform.position = spawnPoint.transform.position;
	}

	public void KillPlayer()
	{
		var player = PlayerNavigator.i.gameObject;
		var blood = Instantiate (splatterPrefab);
		blood.transform.position = player.transform.position;
	}


	public void Kill()
	{
		var player = FindObjectOfType<PlayerNavigator> ();

		var startPos = player.transform.position + Vector3.up * weightHeight;
		var weight = Instantiate (weightPrefab);
		weight.transform.position = startPos;
		var deadstring = deadStrings [Random.Range (0, deadStrings.Length)];
		BossScript.i.bossSays (deadstring);


		var proj = Instantiate (projectorPrefab);
		proj.transform.position = startPos;

		weight.GetComponent<Weight> ().projector = proj;

	}


	IEnumerator killRoutine( )
	{
		while (true)
		{
			yield return new WaitForSeconds ( Random.Range (minTime, maxTime) );
			Kill ();
		}
	}

	// Use this for initialization
	void Start () {
	

		Physics.gravity = Vector3.down * weightSpeed;
		StartCoroutine (killRoutine ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
