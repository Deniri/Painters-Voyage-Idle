using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color0 : MonoBehaviour
{
    public int target;

    public void DealDamage()
    {
        //наносим урон
        if(Random.Range(0f,100f) <= playerManager.artColorCritC[0])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[0] * playerManager.artColorCritM[0];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[0];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }

}
