using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private BulletController BulletController;

    public void Fire()
    {
        BulletController.Run();
    }
}
