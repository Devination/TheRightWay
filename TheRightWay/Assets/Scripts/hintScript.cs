using UnityEngine;
using System.Collections;

public class hintScript {

    public string[] genHintList(GameObject[] machines) {
        string[] hintList = new string[machines.Length];
        int count = 0;
        foreach (GameObject go in machines) {
            Machine m = go.GetComponent<Machine>();
            hintList[count] = m.hints[m.correctState];
            count++;
        }
        return hintList;
    }

}
