using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public List<GameObject> Objects { get; set; }
    private MeteorCreator _creator;
    public void AddPool(GameObject gameObject)
    {
        Objects.Add(gameObject);
    }

    private void Start()
    {
        Objects = new List<GameObject>();
    }
}
