using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hintButtonScript : MonoBehaviour {

    public GameObject hintTextGO;
    public bool blinking;
    float startTime;
    float scale;
    public float blinkSpeed = 3;
    public float blinkAmplitude = .1f;
    public GameObject hintButton;
    RectTransform hintButtonRT;

    void Awake () {
        blinking = true;
        startTime = Time.time;
        hintButtonRT = hintButton.GetComponent<RectTransform>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        blink();
	}

    void blink() {
        if (blinking) {
            scale = 1 + Mathf.Sin(Time.time * blinkSpeed) * blinkAmplitude;
            Debug.Log(Time.time);
            Debug.Log(Mathf.Sin(Time.time));
            Debug.Log(scale);
        } else {
            scale = 1;
        }
        hintButtonRT.localScale = new Vector3(scale, scale, 1);
    }

    public void toggleHintText() {
        blinking = false;
        bool state = hintTextGO.activeSelf;
        hintTextGO.SetActive(!state);
    }
}
