using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideTrigering : MonoBehaviour
{
    public Material currentMaterial;
    [SerializeField] private GameObject currentUIIndicate;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Renderer>().sharedMaterial == currentMaterial)
        {
            currentUIIndicate.GetComponent<UIScoreController>().changeCurrentNumber();
            Destroy(other.gameObject);
        }
    }
}
