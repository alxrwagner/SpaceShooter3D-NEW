using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CreateObject : MonoBehaviour
{
    public GameObject Prefab { get; protected set; }

    public Vector3 SpawnValues;

    [SerializeField]
    public GameObject ObjectSpawn { get; protected set; }
    public Transform SpawnTransform { get; protected set; }

    public abstract GameObject Create();
}
