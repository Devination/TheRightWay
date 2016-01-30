using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Herometer : MonoBehaviour {

    public float value;
    public float maxTime;
    Slider slider;

    void Awake () {
        slider = GetComponent<Slider>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        value = Mathf.Min(1, value + Time.deltaTime/maxTime);
        slider.value = value;
	}
}
