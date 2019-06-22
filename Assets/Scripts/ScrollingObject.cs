using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver)
        {
            body.velocity = Vector2.zero;
        }
    }
}
