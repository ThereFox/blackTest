using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    public GameObject[] scoreUIs;
    public GameObject UIVisibleController;
    private int maxScoreNumber = 0;
    
    
    private void Update()
    {
        if ($"{getScoreNumber()}" == $"{maxScoreNumber}")
        {
            UIVisibleController.GetComponent<UIVisibilityController>().changeActiveValue();
        }
    }

    private int getScoreNumber()
    {
        int score = 0;
        foreach (GameObject scoreUI in scoreUIs)
        {
            score += scoreUI.GetComponent<UIScoreController>().getCurrentNumber();
        }
        return score;
    }

    public void changeMaxScoreNumber(int addedMaxScoreNumber)
    {
        maxScoreNumber += addedMaxScoreNumber;
    }

    public int getMaxScoreNumber()
    {
        return maxScoreNumber;
    }
}
