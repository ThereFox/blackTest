using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueButtonChanger : MonoBehaviour
{
    public Button button;
    [SerializeField] private int step;
    private bool isHold;

    
    private void Start()
    {
        button.onClick.AddListener(changeValue);
    }

    private void Update()
    {
        if (isHold)
        {
            changeValue();
            Debug.Log(Physics.queriesHitTriggers);
        }
    }
    
    private void changeValue()
    {
        int value = GameObject.FindWithTag("redController").GetComponent<valueChanger>().getValue();
        GameObject.FindWithTag("redController").GetComponent<valueChanger>().changeValue(value + step);
        Debug.Log(value + " " + step);
    }
    public void OnMouseDown()
    {
        Debug.Log("+");
        isHold = true;
    }
    public void OnMouseUp()
    {
        Debug.Log("+");
        isHold = false;
    }
}
