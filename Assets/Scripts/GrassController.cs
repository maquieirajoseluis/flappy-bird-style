using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour
{
    private BoxCollider2D grassBoxCollider2D;

    private float grassHorizontalLength;

    // Start is called before the first frame update
    void Start()
    {
        grassBoxCollider2D = GetComponent<BoxCollider2D>();
        grassHorizontalLength = grassBoxCollider2D.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -grassHorizontalLength)
        {
            MoveGrass();
        }
    }

    private void MoveGrass()
    {
        Vector2 grassOffset = new Vector2(grassHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + grassOffset;
    }
}
