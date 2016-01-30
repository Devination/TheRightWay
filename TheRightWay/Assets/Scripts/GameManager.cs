using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Text endText;
    public Slider slider;
    public Text hintText;
    public GameObject[] machines;
    hintScript hs = new hintScript();

    void Awake () {
        endText.text = "";
        populateHintText(machines);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (slider.value == 1) {
            endGame();
        }
	}

    public void endGame() {
        endText.text = "Unacceptable!";
        //this is a global
        PlayerNavigator.i.navAgent.enabled = false;
    }

    void updateText() {
        
    }

    void populateHintText(GameObject[] machines) {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        string[] hintStringArray = hs.genHintList(machines);
        sb.AppendLine("These are your hints:");

        foreach (string s in hintStringArray) {
            Debug.Log(s);
            sb.AppendLine(s);
        }
        hintText.text = sb.ToString();
    }
}
