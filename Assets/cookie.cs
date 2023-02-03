using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookie : MonoBehaviour
{
    public panelAd _panelAd;
    public Image _image;

    public Sprite[] _icon;
    public static int onCookie = 0;

    private float adCd = 180f;
    private float onAd = 1f;

    private void Update()
    {
        if (adCd > 0f)
        {
            adCd -= Time.deltaTime;
            if (adCd <= 0f)
            {
                transform.localPosition = new Vector3(0f + Random.Range(-400f, 500f), 0f + Random.Range(-200f, 200f), 0f);
                onAd = 1f;
            }
        }
        if (onAd > 0f)
        {
            onAd -= 0.1f * Time.deltaTime;
            _image.color = new Vector4(1f, 1f, 1f, onAd);
            if (onAd <= 0.2f)
            {
                transform.localPosition = new Vector3(10000f, 10000f, 0f);
                adCd = 120f;
                onAd = 0;
            }
        }
    }




    private void OnMouseDown()
    {
        _panelAd.gameObject.SetActive(true);
        _panelAd.textUpdate(1); // cookie state 1
        transform.localPosition = new Vector3(10000f, 10000f, 1f);
        adCd = 120f;
        onAd = 0;
    }
}
