using UnityEngine;

public class probe : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2 (-2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "e")
        {
            gameflow.ULchange = "r";
            Destroy(gameObject);
        }

        if (other.tag == gameflow.currentTurn)
        {
            gameflow.ULchange = "y";
            Destroy(gameObject);
        }

        if (other.tag != gameflow.currentTurn)
        {
            other.tag = gameObject.tag;
        }
    }
}
