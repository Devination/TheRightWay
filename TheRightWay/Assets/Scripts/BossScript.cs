using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BossScript : MonoBehaviour {

    public Text bossText;
	public static BossScript i;

	void Awake()
	{
		i = this;
	}

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
        sb.AppendLine("");

        int scoreCheck = 0;
        foreach (GameObject go in machines) {
            Machine m = go.GetComponent<Machine>();
            string s = m.endText[m.currentState];
            sb.Append(s);

            if (m.currentState == m.correctState) {
                scoreCheck++;
            }
        }
        if(scoreCheck == 6) {
            return sb.ToString();
        } else {
            return "You fail!";
        }
    }
}
