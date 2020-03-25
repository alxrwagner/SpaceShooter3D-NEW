using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Objects
{
    [SerializeField] private LifeText _lifeText;

    [SerializeField] private PlayerMove _motor;
    [SerializeField] private Shooting _shooting;
    private Vector3 _borders;

    private void Awake()
    {
        Speed = 5f;
        _borders = new Vector3(-6f, 0f, 0f);

        _lifeText = GameObject.FindGameObjectWithTag("LifeText").GetComponent<LifeText>();
    }

    private void FixedUpdate()
    {
        _motor.Move(Speed);
        _shooting.Fire();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //Deactivate();
            _lifeText.TakeDamage();
        }
    }
}
