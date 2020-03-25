using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objects : MonoBehaviour
{
    public float Speed { get; protected set; }

    protected void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
