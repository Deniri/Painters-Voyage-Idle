using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color3 : MonoBehaviour
{

    public int target;

    public void DealDamage()
    {
        //наносим урон
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[3])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[3] * playerManager.artColorCritM[3];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[3];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
