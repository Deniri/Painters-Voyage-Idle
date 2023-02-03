using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color5 : MonoBehaviour
{

    public int target;
    public int targetNext;
    public int count;

    public void DealDamage()
    {
        //наносим урон
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[5])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[5] * playerManager.artColorCritM[5];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[5];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }

    public void CreateNextStep()
    {
        if (count > 0)
        {
            playerManager._artCanvas.ForColor5(targetNext, count);
        }
        else
        {
            //наносим урон последней цели
            if (Random.Range(0f, 100f) <= playerManager.artColorCritC[5])
            {
                playerManager.artHp[targetNext] -= playerManager.artColorDmg[5] * playerManager.artColorCritM[5];
            }
            else
            {
                playerManager.artHp[targetNext] -= playerManager.artColorDmg[5];
            }
            if (playerManager.artHp[targetNext] <= 0)
                playerManager.UpdateArtHpCur();
        }
    }


    public void EndAnim()
    {          
        gameObject.SetActive(false);
    }
}
