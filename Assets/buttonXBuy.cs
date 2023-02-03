using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonXBuy : MonoBehaviour
{
    public int number;

    public Image _image;
    public Sprite[] icon;

    private bool onOffButton = true;
    public AudioSource _as;


    void Update()
    {
        if (playerManager.xBuyTools == number)
        {
            if (onOffButton == false)
            {
                _image.sprite = icon[0];
                onOffButton = true;
            }
        }
        else
        {
            if (onOffButton == true)
            {
                _image.sprite = icon[1];
                onOffButton = false;
            }
        }
    }

    private void OnMouseUpAsButton()
    {
        if (playerManager.xBuyTools != number)
        {
            playerManager.xBuyTools = number;
            playerManager.UpdateUpgrade();

            if (playerManager.musicOnOff == 0)
                _as.Play();
        }
    }
}
