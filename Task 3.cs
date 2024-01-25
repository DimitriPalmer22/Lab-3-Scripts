using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{

    public int money;

    // Start is called before the first frame update
    void Start()
    {
        int hundreds;
        int fifties;
        int twenties;
        int tens;
        int fives;
        int ones;

        hundreds = money / 100;
        money = money % 100;
        fifties = money / 50;
        money = money % 50;
        twenties = money / 20;
        money = money % 20;
        tens = money / 10;
        money = money % 10;
        fives = money / 5;
        money = money % 5;
        ones = money / 1;
        money = money % 1;

        Debug.Log($"Task 3: {hundreds} 100s. {fifties} 50s. {twenties} 20s. {tens} 10s. {fives} 5s. {ones} 1s.");
    }

}
