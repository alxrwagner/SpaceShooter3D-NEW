using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MeteorCreator : CreateObject
{
    public float SpawnWait;
    public float StartWait;

    public override GameObject Create()
    {
        var meteor = Instantiate(Prefab);
        meteor.transform.position = new Vector3(UnityEngine.Random.Range(-SpawnValues.x, SpawnValues.x), SpawnTransform.position.y, SpawnTransform.position.z);
        meteor.transform.rotation = SpawnTransform.rotation;
        meteor.SetActive(false);

        return meteor;
    }

    private void Awake()
    {
        Prefab = Resources.Load<GameObject>("Prefabs/Meteor");
        ObjectSpawn = GameObject.Find("MeteorSpawn");
        SpawnTransform = ObjectSpawn.transform;
    }
}

