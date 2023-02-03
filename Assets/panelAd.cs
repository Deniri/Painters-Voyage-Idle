using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelAd : MonoBehaviour
{
    public static int state; //if 0 = speed if 1 = cookie
    public TextMeshProUGUI text;
    private void Awake()
    {
        transform.localPosition = new Vector3(0f, 0.5f, -1f);
        gameObject.SetActive(false);
    }




    public void textUpdate(int buttonState)
    {
        state = buttonState;
        if (state == 0)
        {
            text.text = "Would you like to watch an AD and 50% your income for 5 minutes?";
        }
        if (state == 1)
        {
            double moneyyyy = 0;
            moneyyyy += playerManager.incomeMoney * 120;
            text.text = $"Would you like to watch an AD and redeem  <sprite=0>  {playerManager.Reduction_0(moneyyyy)} ?";

        }
    }
}
