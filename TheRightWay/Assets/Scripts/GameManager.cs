using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Text endText;
    public Slider slider;
    public Text hintText;
    public GameObject[] machines;
    GameObject[] hintMachines;
    GameObject[] endMachines;
    hintScript hs = new hintScript();
    public int score;
    public Text scoreText;
    BossScript bs = new BossScript();
    public GameObject endCanvas;

    void Awake () {
        endText.text = "";
        orderMachines();
    }

    void orderMachines () {
        hintMachines = new GameObject[] {
            machines[0],
            machines[1],
            machines[2],
            machines[3],
            machines[4]
        };
        endMachines = new GameObject[] {
            machines[0],
            machines[1],
            machines[2],
            machines[3],
            machines[4]
        };
    }

	// Use this for initialization
	void Start () {
		populateHintText(hintMachines);
	}
	
	// Update is called once per frame
	void Update () {
        computeScore(machines);
        writeScore();
        if (slider.value == 1) {
            endGame();
        }
	}

    public void endGame() {
        endCanvas.SetActive(true);
        endText.text = bs.finalSpeech(endMachines);
        //this is a global
        PlayerNavigator.i.navAgent.enabled = false;
    }

    void updateText() {
        
    }

    void populateHintText(GameObject[] machines) {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        string[] hintStringArray = hs.genHintList(machines);
		sb.AppendLine("Henchman! Herr Bund is on his way. Set up all my deadly devices the way I want them. Oh yes, I can see it now.\n");

        foreach (string s in hintStringArray) {
            Debug.Log(s);
            sb.AppendLine(s);
        }
		sb.AppendLine("Hurry! Our guest is arriving.");

		hintText.text = sb.ToString();
    }

    void computeScore(GameObject[] machines) {
        int tmpScore = 0;
        foreach(GameObject go in machines) {
            Machine m = go.GetComponent<Machine>();
            if(m.correctState == m.currentState) {
                tmpScore++;
            }
        }
        score = tmpScore;
    }

    void writeScore() {
        scoreText.text = "Score: " + score;
    }

}
