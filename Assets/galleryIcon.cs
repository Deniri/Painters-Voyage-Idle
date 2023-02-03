using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galleryIcon : MonoBehaviour
{

    public int number;
    private bool onOff = false;

    public Image _image;
    public Sprite[] _icon;

    void Update()
    {
        if(playerManager.currentLevelMax > number)
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



}
