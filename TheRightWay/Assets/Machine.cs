using UnityEngine;
using System.Collections;

public class Machine : MonoBehaviour {

	public string[] states;
	public string[] hints;
	public string[] animatorStateNames;
	public int currentState;
	public int correctState;
	public Animator animator;


	public void ChangeState( int index )
	{
		animator.SetTrigger (animatorStateNames [index]);
	}
}
