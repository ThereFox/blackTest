using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreController : MonoBehaviour
{
    
    private Text scoreText;
    private int currentNumber = 0;
    
    void Update()
    {
        if (GetComponent<Text>().text != $"{currentNumber}")
        {
            GetComponent<Text>().text = $"{currentNumber}";
        }
    }

    public void changeCurrentNumber()
    {
        currentNumber++;
    }

    public int getCurrentNumber()
    {
        return currentNumber;
    }
}
