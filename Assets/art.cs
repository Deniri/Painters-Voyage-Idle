using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class art : MonoBehaviour
{

    public Image _image;
    public Sprite[] _artIcon;

    public static int currentArt;

    private int queue = 0;
    public GameObject[] ps;

    void Awake()
    {
        playerManager._art = this;
    }

    
    void Update()
    {
        
    }




    public void UpdateArt()
    {
        if(playerManager.currentLevel < 41)
        {
            currentArt = playerManager.currentLevel;
        }
        else
        {
            currentArt = Random.Range(20,41);
        }


        _image.sprite = _artIcon[currentArt];
    }




    public void EndArt()
    {
        queue = 0;
        for(int i = 0; i < 10; i++)
        {
            Invoke("StartPS", i / 10f);
        }
    }
    public void StartPS()
    {
        ps[queue].gameObject.SetActive(true);
        queue += 1;
    }

}
