using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color8 : MonoBehaviour
{
    public int target;

    public void DealDamage()
    {
        //dealing damage
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[8])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[8] * playerManager.artColorCritM[8];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[8];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
