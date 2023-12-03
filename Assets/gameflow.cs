using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public Transform squareObj;
    public static string currentTurn = "w";
    public static string ULchange = "n";
    // Start is called before the first frame update
    void Start()
    {
        for (float y  = 4; y > -5; y -= 0.6f) 
        {
            for (float x = -4; x < 5; x += 0.6f)
            {
                Instantiate(squareObj, new Vector2(x, y), squareObj.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
