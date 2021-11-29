using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueChanger : MonoBehaviour
{
    [SerializeField]private int value;
    public GameObject valueText;
    public char colorationName;

    void Start()
    {
        valueText.GetComponent<Text>().text = $"{value}";
    }


    public void changeValue(int changedValue)
    {
        if (changedValue > -1 && changedValue < 256) {
            value = changedValue;
            valueText.GetComponent<Text>().text = $"{changedValue}";
            GameObject.FindGameObjectWithTag("colorController").GetComponent<changerColors>().changeColorationValue(changedValue, colorationName);
            GameObject.FindGameObjectWithTag("active").GetComponent<colorContainerlController>().changeColorationValue(changedValue, colorationName);
        }
    }
    public int getValue()
    {
        return value;
    }

}
