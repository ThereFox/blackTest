using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changerColors : MonoBehaviour
{
    public GameObject target;
    private float redValue;
    private float greenValue;
    private float blueValue;
    
    

    public void changeColorationValue(int newValue, char coloration)
    {
        switch (coloration)
        {
            case('r'):
                redValue = (float)newValue / 255.0f;
                break;
            case ('g'):
                greenValue = (float)newValue / 255.0f;
                break;
            case ('b'):
                blueValue = (float)newValue / 255.0f;
                break;
        }
        setColorValue();
    }

    private void setColorValue()
    {
        target.GetComponent<Renderer>().material.color = new Color(redValue, greenValue, blueValue);
    }


} 
