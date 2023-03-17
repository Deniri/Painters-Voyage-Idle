using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color6 : MonoBehaviour
{
    public int target;

    public void DealDamage()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[6])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[6] * playerManager.artColorCritM[6];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[6];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
