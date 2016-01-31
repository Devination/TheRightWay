using UnityEngine;
using System.Collections;


public struct MachineStrings
{
	public string[] hint;
	public string[] feedbackGood;
	public string[] feedbackBad;
	public string[] endText;
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

    void Awake() {
        GetStrings();
    }

	public void GetStrings()
	{
        MachineStrings ms = new MachineStrings();
        switch(whichMachine) {
            case WhichMachine.Boiler:
                ms = boiler;
                break;
            case WhichMachine.HatSharpener:
                ms = HatSharpener;
                break;
        }

        hints = ms.hint;
        feedbackBad = ms.feedbackBad;
        feedbackGood = ms.feedbackGood;
        endText = ms.endText;
	}

	public void ChangeState( int index )
	{

		if (index == correctState) {

			BossScript.i.bossSays (feedbackGood [index]);
		} else {

			BossScript.i.bossSays (feedbackBad [index]);
		}
			
		animator.SetTrigger (animatorStateNames [index]);
	}

    static MachineStrings boiler = new MachineStrings {
        hint = new string[] {
            "one",
            "two",
            "three"
        },
        feedbackGood = new string[] {
            "first",
            "second",
            "third"
        },
        feedbackBad = new string[] {
            "uno",
            "dos",
            "trace"
        },
        endText = new string[] {
            "yo",
            "dawg",
            "man"
        }
    };

    static MachineStrings HatSharpener = new MachineStrings {
        hint = new string[] {
            "one",
            "two",
            "three"
        },
        feedbackGood = new string[] {
            "first",
            "second",
            "third"
        },
        feedbackBad = new string[] {
            "uno",
            "dos",
            "trace"
        },
        endText = new string[] {
            "yo",
            "dawg",
            "man"
        }
    };
}
