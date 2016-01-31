using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BossScript : MonoBehaviour {

    public Text bossText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void bossSays(string words) {
        bossText.text = words;
    }

    public string finalSpeech(GameObject[] machines) {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //string[] speechArray = new string[machines.Length];
        sb.AppendLine("End Script:");

        foreach (GameObject go in machines) {
            Machine m = go.GetComponent<Machine>();
            string s = m.endText[m.currentState];
            Debug.Log(s);
            sb.AppendLine(s);
        }
        return sb.ToString();
    }
}
