using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScript1 : MonoBehaviour {

    public string sample = "Hello?";
    int testInt = 0;

    Text text;
    void Awake() {

        text = GetComponent<Text>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        testInt++;
        text.text = sample + testInt;
	}
}
