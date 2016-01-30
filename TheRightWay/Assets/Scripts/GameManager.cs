using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Text endText;
    public Slider slider;

    void Awake () {
        endText.text = "";

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
    }

    void updateText() {
        
    }
}
