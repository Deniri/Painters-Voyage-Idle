using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonTools : MonoBehaviour
{



    public int number;

    public Button _button;
    public GameObject _text;

    public textNameAnim _tna;
    public iconAnim _ia;

    private bool buttonOnOff = true;
    private int levelUp = 25;

    private Vector3 textUp;
    private Vector3 textDown;

    public panelToolsAll pta;

    public AudioSource _as;

    private void Start()
    {
        textUp = _text.transform.localPosition;
        textDown = _text.transform.localPosition;
        textDown.y -= 2;
        levelUp = playerManager.artColorLevel[number] / 25 * 25 + 25;
    }

    private void Update()
    {
        if (playerManager.money >= playerManager.artColorCost[number])
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

            if(number == 0 && playerManager.artColorLevel[number] == 0)
            {
                playerManager.artColorLevel[number] += 1;
            }
            else
            {
                playerManager.money -= playerManager.artColorCost[number];
                playerManager.artColorLevel[number] += playerManager.xBuy[playerManager.xBuyTools];
            }
            
            
            _tna.StartAnim();

            if(levelUp <= playerManager.artColorLevel[number])
            {
                levelUp = playerManager.artColorLevel[number] / 25 * 25 + 25;
                _ia.StartAnim();
            }

            playerManager.UpdateUpgrade();
            pta.UpdateAllPanel();

            if (playerManager.musicOnOff == 0)
                _as.Play();
        }
    }


}
