using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonMus : MonoBehaviour
{

    public Image _image;
    public Sprite[] _icon;

    private bool onOff = true;
    public AudioSource _as;


    private void Start()
    {
        if (playerManager.musicOnOff == 0)
        {
            _as.Play();
        }
        else
        {
            _as.Stop();
        }
    }

    void Update()
    {
        if (playerManager.musicOnOff == 0)
        {
            if (onOff == false)
            {
                _image.sprite = _icon[0];
                onOff = true;
            }
        }
        else
        {
            if (onOff == true)
            {
                _image.sprite = _icon[1];
                onOff = false;
            }
        }
    }




    private void OnMouseDown()
    {
        if (playerManager.musicOnOff == 0)
        {
            _as.Stop();
            playerManager.musicOnOff = 1;
        }
        else
        {
            _as.Play();
            playerManager.musicOnOff = 0;
        }
    }




}
