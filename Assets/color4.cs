using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color4 : MonoBehaviour
{

    public int target;
    public int target2;
    public int target3;
    public int target4;

    public void DealDamage()
    {
        //наносим урон
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[4])
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[4] * playerManager.artColorCritM[4];
        }
        else
        {
            playerManager.artHp[target] -= playerManager.artColorDmg[4];
        }
        if (playerManager.artHp[target] <= 0)
            playerManager.UpdateArtHpCur();
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[4])
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[4] * playerManager.artColorCritM[4];
        }
        else
        {
            playerManager.artHp[target2] -= playerManager.artColorDmg[4];
        }
        if (playerManager.artHp[target2] <= 0)
            playerManager.UpdateArtHpCur();
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[4])
        {
            playerManager.artHp[target3] -= playerManager.artColorDmg[4] * playerManager.artColorCritM[4];
        }
        else
        {
            playerManager.artHp[target3] -= playerManager.artColorDmg[4];
        }
        if (playerManager.artHp[target3] <= 0)
            playerManager.UpdateArtHpCur();
        if (Random.Range(0f, 100f) <= playerManager.artColorCritC[4])
        {
            playerManager.artHp[target4] -= playerManager.artColorDmg[4] * playerManager.artColorCritM[4];
        }
        else
        {
            playerManager.artHp[target4] -= playerManager.artColorDmg[4];
        }
        if (playerManager.artHp[target4] <= 0)
            playerManager.UpdateArtHpCur();
    }

    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
}
