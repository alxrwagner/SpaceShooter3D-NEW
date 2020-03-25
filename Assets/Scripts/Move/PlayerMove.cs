using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Border
{
    public float xMin, xMax, zMin, zMax;
}
public class PlayerMove : MonoBehaviour
{
    public Border Border;
    private float _moveHorizontal;
    private float _moveVertical;

    public void Move(float speed)
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        //transform.Translate(0f, Input.GetAxis("Vertical") * Time.deltaTime * speed, 0f);
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(_moveHorizontal, 0f, _moveVertical) * speed;
        GetComponent<Rigidbody>().position = new Vector3
             (
              Mathf.Clamp(GetComponent<Rigidbody>().position.x, Border.xMin, Border.xMax),
              2.5f,
              Mathf.Clamp(GetComponent<Rigidbody>().position.z, Border.zMin, Border.zMax)
              );
    }
}
