using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneMenegerButtonController : MonoBehaviour
{
    public Button button;
    private void Start()
    {
        button.onClick.AddListener(onClick);
    }
    private void onClick()
    {
        SceneManager.LoadScene(0);
    }
}
