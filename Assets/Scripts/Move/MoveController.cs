using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public void Move(float speed)
    {
        transform.Translate(0f, speed * Time.fixedDeltaTime, 0f);
    }
}
