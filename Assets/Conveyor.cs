using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Animator anim;
    [SerializeField] private float speed;
    [SerializeField] private bool goingRight = true;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        var pos = myRigidbody.position;

        if (goingRight)
        {
            anim.SetBool("Right", true);
            myRigidbody.position += Vector2.left * speed * Time.fixedDeltaTime;
        }
        else
        {
            anim.SetBool("Right", false);
            myRigidbody.position += Vector2.right * speed * Time.fixedDeltaTime;
        }

        myRigidbody.MovePosition(pos);
    }
}
