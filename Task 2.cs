using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    public int bookPrice;
    public int copiesSold;

    private float firstShippingCost = 3;
    private float secondShippingCost = .75f;

    private float discout = .4f;

    private float totalCost;
    private float totalProfit;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < copiesSold; i++) 
        {
            if (i == 0)
            {
                float bookTotalCost = bookPrice * (1 - discout) + firstShippingCost;
                totalCost += bookTotalCost;
                totalProfit += bookPrice - bookTotalCost;
            }
            else
            {
                float bookTotalCost = bookPrice * (1 - discout) + secondShippingCost;
                totalCost += bookTotalCost;
                totalProfit += bookPrice - bookTotalCost;
            }
        }

        Debug.Log($"Task 2: Total Cost: {totalCost}. Total Profit: {totalProfit}");
    }

}
