using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class panelUpgrade : MonoBehaviour
{

    public int number;

    public TextMeshProUGUI textProp;
    public TextMeshProUGUI textCost;

    public Image _image;
    public Sprite[] _icon;





    public void UpdatePanel()
    {
        textProp.text = $"{allTextManager.textToolUpgrades[playerManager.upgradeSort[number]]}";
        textCost.text = $"<sprite=0>{playerManager.Reduction_0(playerManager.upgradeCost[playerManager.upgradeSort[number]])}";


        _image.sprite = _icon[playerManager.upgradeSort[number]];
    }

}
