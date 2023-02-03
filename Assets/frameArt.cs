using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frameArt : MonoBehaviour
{

    public int number;
    public float scaleArt = 1f;

    private Vector3 scaleXY = new Vector3(1f,1f,1f);


    void Update()
    {
        scaleXY.x = (float)(scaleArt / playerManager.artHpMax[number] * playerManager.artHp[number]);
        scaleXY.y = scaleXY.x;
        if(scaleXY.x < 0f)
        {
            scaleXY.x = 0f;
            scaleXY.y = 0f;
        }
        if (scaleXY.x > scaleArt)
        {
            scaleXY.x = scaleArt;
            scaleXY.y = scaleArt;
        }

        transform.localScale = scaleXY;
    }





}
