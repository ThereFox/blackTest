using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVisibilityController : MonoBehaviour
{

    public GameObject changedObject;

    private void Start()
    {
        changedObject.SetActive(false);
    }
    
    public void changeActiveValue()
    {
        changedObject.SetActive(true);
    }
}
