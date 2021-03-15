using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        var pos = myRigidbody.position;
        myRigidbody.MovePosition(pos + Vector2.right * speed * Time.fixedDeltaTime);
    }
}
