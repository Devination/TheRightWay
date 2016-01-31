using UnityEngine;
using System.Collections;


public struct MachineStrings
{
	string[] hint;
	string[] feedbackGood;
	string[] feedbackBad;
	string[] endText;
}


public enum WhichMachine
{
	Boiler, HatSharpener
};

public class Machine : MonoBehaviour {

	public string[] hints;
	public string[] feedbackGood;
	public string[] feedbackBad;
	public string[] endText;
	public string[] states;
	public string[] animatorStateNames;
	public int currentState;
	public int correctState;
	public Animator animator;
	public WhichMachine whichMachine;

	/*
	public MachineStrings GetStrings()
	{
		switch( whichMachine) 
		return 

	}
	*/


	public void ChangeState( int index )
	{
		animator.SetTrigger (animatorStateNames [index]);
	}















	// begin machine strings
	/*
	public static MachineStrings BoilerStrings
	{
		{  "a", "b", "c"


	}
		*/

}
