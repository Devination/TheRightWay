using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MinionNames : MonoBehaviour {

	public static string[] minionNames = 
	{
		"Ms. Sweet Potato",
		"Sister Baby's Breath",
		"Maurice",
		"Mercedes",
		"Severus",
		"Lazar Wolf",
		"Stoogebrush",
		"General Callisto",
		"Dr. Raskolnikov",
		"Tiny",
		"Rabbi Mendel",
		"Vespa",
		"Professor Plum",
		"Javier",
		"Mme Lefevre",
		"Polo",
		"Senor Salazar",
		"The Oscillator",
		"Mr. Pinecone",
		"Junior",
		"The Spindle",
		"Chugg",
		"Minty",
		"Skippy",
		"Rupert",
		"Knuckles",
		"Slim",
		"Mr. Shang",
		"Jingles",
		"Liquidano",
		"Omar",
		"Danna",
		"Kelly",
		"Joe",
		"Devin",
		"Len",
		"Chris",
	};

	public Text nameText;
	public float lerpTime;
	public float scalePlus;

	IEnumerator lerpTextSize()
	{
		var scale = nameText.transform.localScale;
		float timer = 0;
		while (timer < lerpTime/2 ) {
			timer += Time.deltaTime;
			nameText.transform.localScale = Vector3.Lerp (scale, scale + Vector3.one * scalePlus, timer / lerpTime/2);
			yield return null;
		}
		while (timer < lerpTime) {
			timer += Time.deltaTime;
			nameText.transform.localScale = Vector3.Lerp (scale + Vector3.one * scalePlus, scale, (timer/2)/(lerpTime/2) ) ;
			yield return null;
		}

	}

	public void newMinion()
	{
		var name = minionNames[Random.Range(0,minionNames.Length)];
			nameText.text = "Minion #" + Random.Range(0,100000).ToString() + "\n \"" + name + "\"";
		StartCoroutine (lerpTextSize ());
	}

	// Use this for initialization
	void Start () {
		newMinion ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
