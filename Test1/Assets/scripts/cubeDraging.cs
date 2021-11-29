using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class cubeDraging : MonoBehaviour
{
    public Transform Player;
    private Vector3 offset;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
                 Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        Player.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }

}
