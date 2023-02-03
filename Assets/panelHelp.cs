using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelHelp : MonoBehaviour
{
    public int stage = 0;
    public TextMeshProUGUI text1_1;
    public TextMeshProUGUI text1_2;
    public TextMeshProUGUI text2_1;
    public TextMeshProUGUI text2_2;
    public TextMeshProUGUI text2_3;



    private void Awake()
    {
        transform.localPosition = new Vector3(0f,0f,0f);
    }



    private void Start()
    {
        if(playerManager.learnOn != 0)
        {
            gameObject.SetActive(false);
        }
    }




    private void OnMouseUpAsButton()
    {
        if (stage == 0)
        {
            stage = 1;
            text2_1.gameObject.SetActive(true);
            text2_2.gameObject.SetActive(true);
            text2_3.gameObject.SetActive(true);
            text1_1.gameObject.SetActive(false);
            text1_2.gameObject.SetActive(false);
        }
        else if (stage == 1)
        {
            stage = 0;
            playerManager.learnOn = 1;
            text2_1.gameObject.SetActive(false);
            text2_2.gameObject.SetActive(false);
            text2_3.gameObject.SetActive(false);
            text1_1.gameObject.SetActive(true);
            text1_2.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}
