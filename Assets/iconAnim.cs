using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class iconAnim : MonoBehaviour
{
    private int state = 0;
    private int rot = 0;
    private Vector3 scale = new Vector3(1f,1f,1f);

    

    void FixedUpdate()
    {
        if(state == 1)
        {
            rot += 10;
            
            if(rot < 180)
            {
                scale.x += 0.5f * Time.deltaTime;
                scale.y = scale.x;
            }
            if (rot > 180)
            {
                scale.x -= 0.5f * Time.deltaTime;
                scale.y = scale.x;
            }

            if (rot >= 360)
            {
                rot = 0;
                state = 0;
                scale.x = 1;
                scale.y = 1;
            }
            transform.rotation = Quaternion.Euler(0, 0, rot);
            transform.localScale = scale;
        }

        

    }


    public void StartAnim()
    {
        state = 1;
    }

}
