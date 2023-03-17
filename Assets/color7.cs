using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color7 : MonoBehaviour
{
    public int target;
    public int target2;
    public int target3;
    public int target4;
    public int target5;
    public int target6;

    public void DealDamage()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[7])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[7] * playerManager.artColorCritM[7];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[7];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[7])
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[7] * playerManager.artColorCritM[7];
        }
        else
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[7];
        }
        if (playerManager.artHp[target2] <= 0)
            playerManager.UpdateArtHpCur();
    }
    public void DealDamage2()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[7])
        {
            playerManager.artHp[target3] -= playerManager.artColorDmg[7] * playerManager.artColorCritM[7];
        }
        else
        {
            playerManager.artHp[target3] -= playerManager.artColorDmg[7];
        }
        if (playerManager.artHp[target3] <= 0)
            playerManager.UpdateArtHpCur();
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[7])
        {
            playerManager.artHp[target4] -= playerManager.artColorDmg[7] * playerManager.artColorCritM[7];
        }
        else
        {
            playerManager.artHp[target4] -= playerManager.artColorDmg[7];
        }
        if (playerManager.artHp[target4] <= 0)
            playerManager.UpdateArtHpCur();
    }
    public void DealDamage3()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[7])
        {
            playerManager.artHp[target5] -= playerManager.artColorDmg[7] * playerManager.artColorCritM[7];
        }
        else
        {
            playerManager.artHp[target5] -= playerManager.artColorDmg[7];
        }
        if (playerManager.artHp[target5] <= 0)
            playerManager.UpdateArtHpCur();
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[7])
        {
            playerManager.artHp[target6] -= playerManager.artColorDmg[7] * playerManager.artColorCritM[7];
        }
        else
        {
            playerManager.artHp[target6] -= playerManager.artColorDmg[7];
        }
        if (playerManager.artHp[target6] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
