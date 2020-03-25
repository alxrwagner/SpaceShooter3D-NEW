using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform _bulletSpawn;
    public Transform BulletSpawn => _bulletSpawn;

    private float _speed = 1;
    private Vector3 _moveVector;

    public void MovePlayer(float input)
    {
        _moveVector = transform.position;
        _moveVector.x += input;

        transform.position = Vector3.MoveTowards(transform.position, _moveVector, _speed * Time.fixedDeltaTime);
    }

    public void SetStartPosition(Transform targetTransform)
    {
        gameObject.transform.position = targetTransform.position;
        gameObject.transform.rotation = targetTransform.rotation;
    }
}
