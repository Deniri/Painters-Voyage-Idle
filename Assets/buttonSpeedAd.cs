using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonSpeedAd : MonoBehaviour
{
    public TextMeshProUGUI text;
    public panelAd _panelAd;
    public bool isActive;

    private void OnMouseUpAsButton()
    {
        if (playerManager.adSpeedTimer <= 0f)
        {
            _panelAd.gameObject.SetActive(true);
            _panelAd.textUpdate(0);  //speed buff state = 0
        }

    }

    private void Update()
    {
        if (playerManager.adSpeedActive == false)
        {
            text.text = "X2 income";
        }
        else
        {
            text.text = $"{playerManager.Reduction_0(playerManager.adSpeedTimer)} sec.";
        }
    }
}
