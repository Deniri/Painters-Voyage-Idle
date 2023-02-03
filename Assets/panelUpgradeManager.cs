using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelUpgradeManager : MonoBehaviour
{



    public panelUpgrade[] _allPanelUpgrade;

    public RectTransform _rt;

    private int count = 0;
    private Vector2 sd = new Vector2(704f,102f);


    private void OnEnable()
    {
        UpdateAllPanel();
    }




    public void UpdateAllPanel()
    {
        for(int i = 0; i < playerManager.upgradeAmount; i++)
        {
            if(playerManager.upgradeSort[i] >= 0)
            {
                _allPanelUpgrade[i].gameObject.SetActive(true);
                _allPanelUpgrade[i].UpdatePanel();
                count = i;
            }
            else
            {
                _allPanelUpgrade[i].gameObject.SetActive(false);
            }
        }

        sd.y = 106f + 104 * (count / 2);
        _rt.sizeDelta = sd;

    }


}
