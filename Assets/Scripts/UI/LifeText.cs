using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeText : MonoBehaviour
{
    [SerializeField] private Text _lifeTxt;
    public int Life { get; set; } = 3;

    private void Awake()
    {
        _lifeTxt = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        _lifeTxt.text = "Жизни: " + Life;
    }

    public void TakeDamage()
    {
        Life -= 1;
    }
}
