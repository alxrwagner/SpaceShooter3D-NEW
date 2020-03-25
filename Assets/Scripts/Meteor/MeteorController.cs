using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    int Pause = 100;

    public MeteorCreator MeteorCreator;

    public int MeteorCount = 10;
    public bool WillGrow = false;

    public List<GameObject> Meteors = new List<GameObject>();

    private void Update()
    {
        if (Pause > 0) Pause -= 1;
    }

    public void Run()
    {
        if(Pause <= 0)
        {
            GameObject newMeteor = GetPooledObject();
            if (newMeteor != null)
            {
                newMeteor.transform.position = new Vector3(Random.Range(-MeteorCreator.SpawnValues.x, MeteorCreator.SpawnValues.x), MeteorCreator.SpawnTransform.position.y, MeteorCreator.SpawnTransform.position.z);
                newMeteor.SetActive(true);
            }
            Pause = 100;
        }
    }
    private void FixedUpdate()
    {
        Run();
    }
    public GameObject AddPool()
    {
        GameObject obj = MeteorCreator.Create();
        Meteors.Add(obj);
        return obj;
    }

    private void Start()
    {
        MeteorCreator = GetComponent<MeteorCreator>();
        for (int i = 0; i < MeteorCount; i++)
        {
            AddPool();
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < Meteors.Count; i++)
        {
            if (!Meteors[i].activeSelf)
            {
                return Meteors[i];
            }
        }
        if (WillGrow)
        {
            return AddPool();
        }

        return null;
    }
}
