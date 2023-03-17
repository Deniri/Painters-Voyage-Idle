using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color2 : MonoBehaviour
{


    public int target;
    public int target2;

    public void DealDamage()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[2])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[2] * playerManager.artColorCritM[2];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[2];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }
    public void DealDamage2()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[2])
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[2] * playerManager.artColorCritM[2];
        }
        else
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[2];
        }
        if (playerManager.artHp[target2] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
