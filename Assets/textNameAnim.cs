using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textNameAnim : MonoBehaviour
{

    private int state = 0;
    private Vector3 pos;
    private Vector3 scale;
    private float startPos;

    private void Awake()
    {
        startPos = transform.localPosition.y;
        pos = transform.localPosition;
        scale = transform.localScale;
    }

    void Update()
    {
        if(state == 1)
        {
            pos.y += 40f * Time.deltaTime;
            scale.x += 2f * Time.deltaTime;
            scale.y = scale.x;
            if (pos.y >= startPos + 4f)
            {
                state = 2;
                pos.y = startPos + 4f;
            }
            transform.localPosition = pos;
            transform.localScale = scale;
        }
        if (state == 2)
        {
            pos.y -= 40f * Time.deltaTime;
            scale.x -= 2f * Time.deltaTime;
            scale.y = scale.x;
            if (pos.y <= startPos)
            {
                state = 0;
                pos.y = startPos;
                scale.x = 1f;
                scale.y = 1f;
            }
            transform.localPosition = pos;
            transform.localScale = scale;
        }
    }



    public void StartAnim()
    {
        state = 1;
    }

}
