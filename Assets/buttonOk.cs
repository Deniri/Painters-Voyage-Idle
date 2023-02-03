using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonOk : MonoBehaviour
{


    public GameObject panel;

    public TextMeshProUGUI textP;
    public double moneyyyy = 0;

    private void OnEnable()
    {
        
        moneyyyy = playerManager.incomeMoney * 120;
    }


    private void Update()
    {
        textP.text = $"Your reward\n<sprite=0> {playerManager.Reduction_2(moneyyyy)}";
    }

    private void OnMouseDown()
    {
        panel.gameObject.SetActive(false);
    }

}
