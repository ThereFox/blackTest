using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spavnCubeController : MonoBehaviour
{
	public GameObject spavnedPrefab;
	public float timeStep;
	//private GameObject scoreController = GameObject.FindWithTag("scoreIndicator");
	
	private float randX;
	private Vector3 spavnPosition;
	private int quantity;
	
	public GameObject spavnerObject;
    // Start is called before the first frame update
    void Start()
    {
	    quantity = Random.Range(1, 10);

	    GameObject.FindWithTag("scoreIndicator").GetComponent<UIController>().changeMaxScoreNumber(quantity);
	    
	    for (int i = 0; i < quantity; i++)
	    {
		    StartCoroutine(spavnObjects());   
	    }

    }

    IEnumerator spavnObjects()
    {
	    yield return new WaitForSeconds(timeStep);
	    randX = Random.Range(-2.5f, 1.0f);
	    spavnPosition = new Vector3(randX, transform.position.y, 0);
	    Instantiate(spavnedPrefab, spavnPosition, Quaternion.identity);
    }
}
