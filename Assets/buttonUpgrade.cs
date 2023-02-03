using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonUpgrade : MonoBehaviour
{


    public int number;

    public Button _button;
    public GameObject _text;

    public panelUpgradeManager _pum;

    private bool buttonOnOff = true;

    private Vector3 textUp;
    private Vector3 textDown;

    public AudioSource _as;

    private void Start()
    {
        textUp = _text.transform.localPosition;
        textDown = _text.transform.localPosition;
        textDown.y -= 2;
    }

    private void Update()
    {
        if (playerManager.money >= playerManager.upgradeCost[playerManager.upgradeSort[number]])
        {
            if (buttonOnOff == false)
            {
                _button.interactable = true;
                buttonOnOff = true;
            }
        }
        else
        {
            if (buttonOnOff == true)
            {
                _button.interactable = false;
                buttonOnOff = false;
            }
        }
    }


    private void OnMouseDown()
    {
        if (buttonOnOff == true)
            _text.transform.localPosition = textDown;
    }
    private void OnMouseUp()
    {
        _text.transform.localPosition = textUp;
    }



    public void OnMouseUpAsButton()
    {
        if (buttonOnOff == true)
        {
            playerManager.money -= playerManager.upgradeCost[playerManager.upgradeSort[number]];
            playerManager.upgradeLevel[playerManager.upgradeSort[number]] += 1;

            playerManager.UpdateUpgrade();
            _pum.UpdateAllPanel();

            if (playerManager.musicOnOff == 0)
                _as.Play();
        }
    }
}
