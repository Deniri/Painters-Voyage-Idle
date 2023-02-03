using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrazyGames;

public class buttonYesNo : MonoBehaviour
{
    public int number;
    public panelAd _panelAd;
    public GameObject _panelAdreward;






    void successCallback()
    {
        Debug.Log("Video completed - Offer a reward to the player");

        if (panelAd.state == 0)
        {
            playerManager.adSpeedActive = true;
            playerManager.adSpeedTimer = 300f;

        }
        if (panelAd.state == 1)
        {
            playerManager.money += playerManager.incomeMoney * 120;
            _panelAdreward.gameObject.SetActive(true);

        }
        _panelAd.gameObject.SetActive(false);
    }

    void errorCallback()
    {
        Debug.Log("Video not completed");
        _panelAd.gameObject.SetActive(false);

    }









    private void OnMouseUpAsButton()
    {
        if (number == 0)
        {
            CrazyAds.Instance.beginAdBreakRewarded(successCallback, errorCallback);
            _panelAd.gameObject.SetActive(false);
        }
        else
        {
            _panelAd.gameObject.SetActive(false);
        }
    }
}
