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
	public GameObject walkPoint;

	public string[] deadStrings = 
	{
		"Goodbye.",
		"You've worn out your welcome.",
		"It's Mr. Dingleberry's feeding time.",
		"Next!",
		"Ta ta!",
		"Enough!",
		"What is that large object that was just released above your head?",
		"To think, I thought you might succeed.",
		"No more!",
		"It's been a while since I've squished anybody.",
		"Jeeves! Get me some tea and clean up this mess.",
	};


	IEnumerator WaitToRespawn()
	{
		var panels = FindObjectsOfType<InstrumentPanel> ();
		FindObjectOfType<MinionNames> ().newMinion ();
		foreach ( var p in panels) {
			p.gameObject.SetActive (false);
		}
		var player = FindObjectOfType<PlayerNavigator> ();
		player.transform.position = spawnPoint.transform.position;
		player.navAgent.SetDestination (walkPoint.transform.position );
		player.off = true;
		yield return new WaitForSeconds (respawnTime);
		player.off = false;
	}

	public void KillPlayer()
	{
		var player = PlayerNavigator.i.gameObject;
		var blood = Instantiate (splatterPrefab);
		blood.transform.position = player.transform.position;
		var pos = blood.transform.position;
		pos.y = .1f;
		blood.transform.position = pos;
		StartCoroutine (WaitToRespawn ());
	}


	public void Kill()
	{
		var player = PlayerNavigator.i.gameObject;

		var startPos = player.transform.position + Vector3.up * weightHeight;
		var weight = Instantiate (weightPrefab);
		weight.name = "weight";
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
