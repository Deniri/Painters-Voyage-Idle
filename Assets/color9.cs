using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color9 : MonoBehaviour
{
    public int target;
    public int targetNext;

    public int count;

    public void DealDamage()
    {
        //наносим урон
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[9])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[9] * playerManager.artColorCritM[9];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[9];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }
    public void DealDamage2()
    {
        //наносим урон
        if (count == 3 || count == 1)
        {
            if (Random.Range(0f, 100f) <= playerManager.artColorCritC[9])
            {
                playerManager.artHp[target - 21] -= playerManager.artColorDmg[9] * playerManager.artColorCritM[9];
            }
            else
            {
                playerManager.artHp[target - 21] -= playerManager.artColorDmg[9];
            }
            if (playerManager.artHp[target - 21] <= 0)
                playerManager.UpdateArtHpCur();
        }
        else
        {
            if (Random.Range(0f, 100f) <= playerManager.artColorCritC[9])
            {
                playerManager.artHp[target - 19] -= playerManager.artColorDmg[9] * playerManager.artColorCritM[9];
            }
            else
            {
                playerManager.artHp[target - 19] -= playerManager.artColorDmg[9];
            }
            if (playerManager.artHp[target - 19] <= 0)
                playerManager.UpdateArtHpCur();
        }   
    }


    public void CreateNextStep()
    {
        if (count == 3)
        {
            playerManager._artCanvas.ForColor9(targetNext - 1, count - 1);
        }
        else
        {
            if(count == 4 || count == 2)
                playerManager._artCanvas.ForColor9(targetNext + 1, count - 1);
        }
        
    }

    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
