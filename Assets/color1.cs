using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color1 : MonoBehaviour
{

    public int target;
    public int target2;

    public void DealDamage()
    {
        //наносим урон
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[1])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[1] * playerManager.artColorCritM[1];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[1];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
    }
    public void DealDamage2()
    {
        //наносим урон
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[1])
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[1] * playerManager.artColorCritM[1];
        }
        else
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[1];
        }
        if (playerManager.artHp[target2] <= 0)
            playerManager.UpdateArtHpCur();
    }


    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
