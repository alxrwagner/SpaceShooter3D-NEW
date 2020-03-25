using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Text _scoreTxt;
    public int Score { get; set; }  = 0;

    private void Awake()
    {
        _scoreTxt = GetComponent<Text>();
    }
    private void FixedUpdate()
    {
        _scoreTxt.text = "Счет: " + Score;
    }

    public void IsScore()
    {
        Score += 1;
    }
}
