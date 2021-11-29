using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueScrollbarChanger : MonoBehaviour
{
    [SerializeField] private Scrollbar Scrollbar;

    private void Start()
    {
        float scrollbarValue = (Scrollbar.GetComponent<Scrollbar>().value) * 255;
        GameObject.FindWithTag("greenController").GetComponent<valueChanger>().changeValue((int)scrollbarValue);

        Scrollbar.onValueChanged.AddListener(OnValueChanger);
    }

    private void OnValueChanger(float chang)
    {
        float scrollbarValue = (Scrollbar.GetComponent<Scrollbar>().value) * 255;
        GameObject.FindWithTag("greenController").GetComponent<valueChanger>().changeValue((int)scrollbarValue);
    }
}
