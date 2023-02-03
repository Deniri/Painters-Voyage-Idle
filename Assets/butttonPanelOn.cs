using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butttonPanelOn : MonoBehaviour
{
    public int number;


    public Image _image;
    public Sprite[] _icon;

    public AudioSource _as;

    private bool onOff = true;


    private void Update()
    {
        if(playerManager.panelOn == number)
        {
            if(onOff == false)
            {
                _image.sprite = _icon[1];
                onOff = true;
            }
        }
        else
        {
            if (onOff == true)
            {
                _image.sprite = _icon[0];
                onOff = false;
            }
        }
    }



    private void OnMouseUpAsButton()
    {
        if(playerManager.panelOn != number)
        {
            playerManager.panelOn = number;
            playerManager.OpenPanelOn();

            if(playerManager.musicOnOff == 0)
                _as.Play();
        }
    }
}
