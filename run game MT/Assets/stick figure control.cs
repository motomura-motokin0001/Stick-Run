using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickfigurecontrol : MonoBehaviour

{
public float speed = 10;

public Vector3 objNormalVector = Vector3.zero;

public Rigidbody rb;

public Vector3 afterRectVelocity = Vector3.zero;

private bool _isShot = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(!_isShot && Input.GetMouseButtonDown(0))
        {
            ShootBall();
            _isShot = true;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        objNormalVector = collision.contacts[0].normal;
        Vector3 reflectVec = Vector3.Reflect(afterRectVelocity,objNormalVector);
        rb.velocity = reflectVec;
        afterRectVelocity = rb.velocity;
    }

    private void ShootBall()
    {
        var force = (transform.forward + transform.right) * speed;
        rb.velocity = force;
        afterRectVelocity = rb.velocity; 
    }
}
