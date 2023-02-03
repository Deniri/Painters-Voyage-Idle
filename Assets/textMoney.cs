using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textMoney : MonoBehaviour
{

    public TextMeshProUGUI _textMoney;
    public TextMeshProUGUI _textMoneyIncome;
    public TextMeshProUGUI _textIncome;
    public TextMeshProUGUI _textName;

    void Update()
    {
        _textMoney.text = $"<sprite=0>{playerManager.Reduction_2(playerManager.money)}";


        if (playerManager.adSpeedTimer > 0)
        {
            _textMoneyIncome.text = $"+ <sprite=0>{playerManager.Reduction_2(playerManager.incomeMoney * 1.5d)} per sec.";
        }
        else
        {
            _textMoneyIncome.text = $"+ <sprite=0>{playerManager.Reduction_2(playerManager.incomeMoney)} per sec.";
        }


        
        _textIncome.text = $"+ <sprite=0>{playerManager.Reduction_2((playerManager.currentLevel / 10d + 0.1))} per pixel";
        

        if(0.3f >= 1f / playerManager.artCountMax * playerManager.artCount)
        {
            _textName.text = $"{allTextManager.textNameArt[art.currentArt]}";
        }
        else
        {
            _textName.text = $"???";
        }
    }
}
