using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickON : MonoBehaviour
{
    public Transform wtokenObj;
    public Transform btokenObj;
    public Transform probeULObj;
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameflow.currentTurn == "w")
        {
            Instantiate(wtokenObj, transform.position, wtokenObj.rotation);
            StartCoroutine(waittochangeB());
            //gameflow.currentTurn = "b";
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(probeULObj, transform.position, probeULObj.rotation);
        }
        else
        if (gameflow.currentTurn == "b")
        {
            Instantiate(btokenObj, transform.position, btokenObj.rotation);
            StartCoroutine(waittochangeW());
            //gameflow.currentTurn = "w";
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(probeULObj, transform.position, probeULObj.rotation);
        }
    }
    IEnumerator waittochangeW()
    {
        yield return new WaitForSeconds(6);
        gameflow.currentTurn = "w";
        gameflow.ULchange = "n";
    }

    IEnumerator waittochangeB()
    {
        yield return new WaitForSeconds(6);
        gameflow.currentTurn = "w";
        gameflow.ULchange = "n";
    }

}
