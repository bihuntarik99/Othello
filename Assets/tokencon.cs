using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tokencon : MonoBehaviour
{
    public string curColor;

    // Start is called before the first frame update
    void Start()
    {
        curColor = gameObject.tag;
        GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(activateDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow.ULchange=="y") && (curColor=="b"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            gameObject.tag = "w";
        }

        if ((gameflow.ULchange == "y") && (curColor == "w"))
        {
            GetComponent<SpriteRenderer>().color = new Color(0,0,0);
            gameObject.tag = "b";
        }

        if ((gameflow.ULchange == "r") && (curColor == "b"))
        {
            gameObject.tag = "b";
        }

        if ((gameflow.ULchange == "r") && (curColor == "w"))
        {
            gameObject.tag = "w";
        }

    }

    IEnumerator activateDelay()
    {
        yield return new WaitForSeconds(2);
        GetComponent<CircleCollider2D>().enabled=true;
    }
}
