using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DiceValues = new int[2];
    }
    public int[] DiceValues;
    public int DiceTotal
    public void RollTheDice()
    {
        DiceTotal = 0;
        ; for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range(1, 3);
            DiceTotal += DiceValues[i];
        }

        Debug.Log("Rolled: " + DiceValues + " (" + DiceTotal + ")");
    }

}
