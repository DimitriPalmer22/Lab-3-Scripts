using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{

    public int numModules;
    public int readingMaterials;
    public int quizzes;
    public int assignments;
    public bool taughtBefore;

    public string courseName;

    private float totalValue;

    private int numWeeks = 10;

    // Start is called before the first frame update
    void Start()
    {
        numModules = Clamp(numModules, 0, numWeeks);
        readingMaterials = Clamp(readingMaterials, 0, numWeeks);
        quizzes = Clamp(quizzes, 0, numWeeks);
        assignments = Clamp(assignments, 0, numWeeks);

        int taughtNumber = 1;
        if (taughtBefore)
            taughtNumber = 0;

        totalValue = 
            (((float)numModules / numWeeks * .15f * 100) + // 5 / 10 => .50 * .15
            ((float)readingMaterials / numWeeks * .30f * 100) + 
            ((float)quizzes / numWeeks * .15f * 100) + 
            ((float)assignments / numWeeks * .30f * 100) + 
            ((float)taughtNumber * 10f)) / 10;

        //Debug.Log(((float)numModules / numWeeks * .15f));
        //Debug.Log(((float)readingMaterials / numWeeks * .30f));
        //Debug.Log(((float)quizzes / numWeeks * .15f));
        //Debug.Log(((float)assignments / numWeeks * .30f));
        //Debug.Log(((float)taughtNumber * 10f));
        //Debug.Log(numWeeks);

        Debug.Log($"Task 1: {courseName} {totalValue}");
    }

    int Clamp(int value, int min, int max)
    {
        if (value < min)
            return min;
        else if (value > max) 
            return max;
        
        return value;
    }

}
