using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class panelTools : MonoBehaviour
{

    public int number;

    public bool onPanel = false;

    public TextMeshProUGUI TextName;
    public TextMeshProUGUI TextBar;
    public TextMeshProUGUI TextTimer;
    public TextMeshProUGUI TextCost;
    public TextMeshProUGUI TextXBuy;

    public Image _image;
    public GameObject _bar;

    private Vector3 scale = new Vector3(1f,1f,1f);
    private Vector3 scalePanel = new Vector3(0f, 0f, 1f);


   


    void Update()
    {
        TextName.text = $"{allTextManager.textNameTools[number]}";
        TextBar.text = $" {playerManager.Reduction_0(playerManager.artColorDmg[number])}";
        TextTimer.text = $"{playerManager.Timer00(playerManager.artColorBar[number])}";
        


        if(number == 0 && playerManager.artColorLevel[number] == 0)
        {
            TextCost.text = $"<sprite=0> FREE";
            TextXBuy.text = $"Buy x1";
        } 
        else
        {
            TextCost.text = $"<sprite=0>{playerManager.Reduction_0(playerManager.artColorCost[number])}";
            TextXBuy.text = $"Buy x{playerManager.xBuy[playerManager.xBuyTools]}";
        }
            



        //бар х25
        _image.fillAmount = 1f / 25 * (playerManager.artColorLevel[number] - playerManager.artColorLevel[number] / 25 * 25);
        //бар
        scale.x = 1f / playerManager.artColorBarMax[number] * (playerManager.artColorBarMax[number] - playerManager.artColorBar[number]);
        if (scale.x > 1f)
            scale.x = 1f;
        if (scale.x < 0f)
            scale.x = 0f;
        _bar.transform.localScale = scale;




        if (scalePanel.x < 1f)
        {
            scalePanel.x += 2f * Time.deltaTime;
            scalePanel.y += 2f * Time.deltaTime;
            transform.localScale = scalePanel;
            if (scalePanel.x >= 1f)
            {
                scalePanel.x = 1f;
                scalePanel.y = 1f;
                transform.localScale = scalePanel;
            }
        }

    }





    public void UpdateStart()
    {
        if (onPanel == false)
        {
            onPanel = true;
            scalePanel.x = 0f;
            scalePanel.y = 0f;
        }
        transform.localScale = scalePanel;
    }


}
