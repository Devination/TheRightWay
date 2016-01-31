using UnityEngine;
using System.Collections;


public struct MachineStrings
{
	public string[] name;
	public string[] hint;
	public string[] feedbackGood;
	public string[] feedbackBad;
	public string[] endText;
}

public enum WhichMachine
{
	Boiler, HatSharpener, OperatingTable, Tank, Desk, Stairs
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
			case WhichMachine.OperatingTable:
				ms = OperatingTable;
				break;
			case WhichMachine.Tank:
				ms = Tank;
				break;
			case WhichMachine.Desk:
				ms = Desk;
				break;
			case WhichMachine.Stairs:
				ms = Stairs;
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
		name = new string[] {
			"pond",
			"bubble bath",
			"magma"
		},
		hint = new string[] {
            "I'll start by making him glisten.",
			"I'll start by soothing his aches.",
            "I'll start by blowing him away."
        },
        feedbackGood = new string[] {
            "Mwahahaha",
            "Feisty flunky!",
            "Yesssss..."
        },
        feedbackBad = new string[] {
            "Sigh...",
            "I am disappoint",
            "You floundering fool!"
        },
        endText = new string[] {
            "After getting poached, ",
            "After being simmered, ",
            "After being boiled, ",
        }
    };

    static MachineStrings HatSharpener = new MachineStrings {
		name = new string[] {
			"off",
			"poisoned",
			"serrated",
			"sharpened"
		},
		hint = new string[] {
            "You! Get me my crown!",
            "You! Stop by the miasmic millinery.",
            "You! Get back to the grind!",
			"You! Help me whet my appetite for destruction, and my most favored accessory."
        },
        feedbackGood = new string[] {
            "Take THAT!",
            "You are not utterly incompetent.",
            "A fitting ending.",
			"Adequate."
        },
        feedbackBad = new string[] {
            "You imbecile!",
            "I do not tolerate imperfection.",
			"Pathetic.",
			"Useless."
        },
        endText = new string[] {
			"Herr Bünd was left whole ",
			"Herr Bünd was flavored ",
			"Herr Bünd was chopped into cutlets ", 
			"Herr Bünd was sliced very thin "
        }
    };
	static MachineStrings OperatingTable = new MachineStrings {
		name = new string[] {
			"off",
			"saw blade",
			"laser",
			"clippers"
		},
		hint = new string[] {
			"Then, I'll get to have my way with him ",
			"Then, I'll get to shut him up ",
			"Then, I'll get to watch him squirm ",
			"Then, I'll get to make him scream "

		},
		feedbackGood = new string[] {
			"A fitting ending",
			"Let's see how clever your schemes are now, Herr Bünd!",
			"You sly dog!",
			"Can't run now!"
		},
		feedbackBad = new string[] {
			"Maladroit misfit!",
			"That death is too quick.",
			"Unacceptable",
			"Are *you* going to carry him to the next deadly device?"
		},
		endText = new string[] {
			"The Master also had some good old fashioned fun with him. ",
			"The Master also decapitated him, just to shut him up. ",
			"The Master also cut him in half, just for laughs. ",
			"The Master also depoditated him, just for kicks. "

		}
	};
	static MachineStrings Tank = new MachineStrings {
		name = new string[] {
			"shark",
			"piranhas",
			"manatee"
		},
		hint = new string[] {
			"and my pet will feed.",
			"and the children will feast.",
			"and he'll die explosively."
		},
		feedbackGood = new string[] {
			"You did something right.",
			"Passable.",
			"Sufficient."
		},
		feedbackBad = new string[] {
			"Wretched.",
			"I'm growing impatient.",
			"*Hiss*"
		},
		endText = new string[] {
			"and served to Bubbles. ",
			"and served to the school children. ",
			"and served to Ms. Beatrice. "
		}
	};
	static MachineStrings Desk = new MachineStrings {
		name = new string[] {
			"shoelaces",
			"Jupiter",
			"bees"
		},
		hint = new string[] {
			"Soon, the whole world will collapse!",
			"Soon, no man shall step foot upon my vast demesne!",
			"Soon, humanity will swallow a bitter pill!"
		},
		feedbackGood = new string[] {
			"All is not lost.",
			"It's so big!",
			"Fly, my pretties!"
		},
		feedbackBad = new string[] {
			"You don't know my master plan?",
			"You don't know my master plan?",
			"You don't know my master plan?"
		},
		endText = new string[] {
			"With that pesky spy out of the way, Mr. Dingleberry quickly succeeded in burning all the world's shoelaces and watching everybody fall on their faces.",
			"With that pesky spy out of the way, Mr. Dingleberry quickly succeeded in creating an insualted, viable habitat in the middle of our solar system's largest gaseous planet.",
			"With that pesky spy out of the way, Mr. Dingleberry quickly succeeded in freeing the bees to pollinate his favorite flowers."
		}
	};
	static MachineStrings Stairs = new MachineStrings {
		name = new string[] {
			"normal",
			"folded"
		},
		hint = new string[] {
			"I can't wait to give him a workout.",
			"I can't wait to show him my favorite playground attraction."
		},
		feedbackGood = new string[] {
			"Climb, baby, climb!",
			"Weeeeee!"
		},
		feedbackBad = new string[] {
			"That's boring.",
			"You're a sorry excuse for a minion."
		},
		endText = new string[] {
			"toughened, ",
			"tenderized, "
		}
	};
}
