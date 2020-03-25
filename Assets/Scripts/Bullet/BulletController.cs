using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    int Pause = 30;

    public BulletCreator BulletCreator;

    public int BulletCount = 20;
    public bool WillGrow = false;

    public List<GameObject> Bullets = new List<GameObject>();

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < Bullets.Count; i++)
        {
            if (!Bullets[i].activeSelf)
            {
                return Bullets[i];
            }
        }
        if (WillGrow)
        {
            return AddPool();
        }

        return null;
    }

    public void Run()
    {
        if (Pause <= 0)
        {
            GameObject newBullet = GetPooledObject();
            if (newBullet != null)
            {
                newBullet.transform.position = BulletCreator.ObjectSpawn.transform.position;
                newBullet.SetActive(true);
            }
            Pause = 30;
        }
    }
    
    public GameObject AddPool()
    {
        GameObject obj = BulletCreator.Create();
        Bullets.Add(obj);
        return obj;
    }

    private void Start()
    {
        BulletCreator = GetComponent<BulletCreator>();
        for (int i = 0; i < BulletCount; i++)
        {
            AddPool();
        }
    }

    private void Update()
    {
        if (Pause > 0) Pause -= 1;
    } 
}
