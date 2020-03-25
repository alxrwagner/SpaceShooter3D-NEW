using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : Objects
{
    [SerializeField] private ScoreText _scoreText;
    private void Awake()
    {
        Speed = 10f;
        _scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreText>();
    }

    private void FixedUpdate()
    {
        transform.Translate(0f, 0f, Speed * Time.deltaTime, Space.World);
        if (gameObject.transform.position.z >= 15f)
        {
            Deactivate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.tag == "Enemy")
        {
            Deactivate();
            _scoreText.IsScore();
        }
    }
}
