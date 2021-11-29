using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorContainerlController : MonoBehaviour
{
    public GameObject usesPanel;
    public Button button;
    private float red;
    private float green;
    private float blue;

    private void Start()
    {
        red = 0;
        green = 0;
        blue = 0;
        button.onClick.AddListener(changeActivity);
    }
    public void changeColorationValue(int newValue, char coloration)
    {
        switch (coloration)
        {
            case ('r'):
                red = (float)newValue / 255.0f;
                break;
            case ('g'):
                green = (float)newValue / 255.0f;
                break;
            case ('b'):
                blue = (float)newValue / 255.0f;
                break;
        }
        setColorValue();
    }

    private void setColorValue()
    {
        usesPanel.GetComponent<Image>().color = new Color(red, green, blue);
    }


    public void changeActivity()
    {
        GameObject.FindGameObjectWithTag("active").tag = "disabled";
        usesPanel.tag = "active";

        GameObject.FindGameObjectWithTag("redController").GetComponent<valueChanger>().changeValue((int)(red * 255));
        GameObject.FindGameObjectWithTag("greenController").GetComponent<valueChanger>().changeValue((int)(green * 255));
        GameObject.FindGameObjectWithTag("blueController").GetComponent<valueChanger>().changeValue((int)(blue * 255));
    }
}
