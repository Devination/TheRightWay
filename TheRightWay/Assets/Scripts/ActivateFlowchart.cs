using UnityEngine;
using System.Collections;

public class ActivateFlowchart : MonoBehaviour {

    public GameObject flowchart;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void turnOnFlowchart ()
    {
        flowchart.SetActive(true);
	}
}
