using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelON : MonoBehaviour
{

    public int number;


    private void Awake()
    {
        playerManager._panelON[number] = this;
        transform.localPosition = new Vector3(0f,0.5f,0f);
    }


}
