using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;

    private bool isDead = false;

    private Rigidbody2D birdRigidbody2D;

    private Animator birdAnimator;

    // Start is called before the first frame update
    void Start()
    {
        birdRigidbody2D = GetComponent<Rigidbody2D>();
        birdAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                birdRigidbody2D.velocity = Vector2.zero;
                birdRigidbody2D.AddForce(new Vector2(0, upForce));
                birdAnimator.SetTrigger("Flap");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        birdRigidbody2D.velocity = Vector2.zero;
        isDead = true;
        birdAnimator.SetTrigger("Die");
        GameController.instance.BirdDie();
    }
}
