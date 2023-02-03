using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelToolsAll : MonoBehaviour
{
    public panelTools[] _allPanel;
    public static Vector2 scaleXY;


    

    private void OnEnable()
    {
        UpdateAllPanel();
       
    }


    public void UpdateAllPanel()
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i == 0 || playerManager.artColorLevel[i - 1] > 0)
            {
                _allPanel[i].gameObject.SetActive(true);
                _allPanel[i].UpdateStart();
                count = i;
            }
            else
            {
                _allPanel[i].gameObject.SetActive(false);
                _allPanel[i].onPanel = false;
            }
        }
    }
}
