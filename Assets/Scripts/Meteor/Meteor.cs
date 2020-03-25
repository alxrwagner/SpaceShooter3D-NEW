using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : Objects
{
    private void Awake()
    {
        Speed = 6f;
    }

    private void FixedUpdate()
    {
        transform.Translate(0f, 0f, -Speed * Time.deltaTime);
        if (gameObject.transform.position.z <= -15f)
        {
            Deactivate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet" || other.tag == "Player")
        {
            Deactivate();
        }
    }
}
