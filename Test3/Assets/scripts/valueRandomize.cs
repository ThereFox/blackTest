using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueRandomize : MonoBehaviour
{
    [SerializeField] private Button button;
    private void Start()
    {
        button.onClick.AddListener(onClick);
    }
    private void onClick()
    {
        int newValue = Random.Range(0, 256);
        GameObject.FindWithTag("blueController").GetComponent<valueChanger>().changeValue(newValue);
    }
}
