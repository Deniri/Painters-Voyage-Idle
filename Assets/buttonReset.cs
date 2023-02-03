using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonReset : MonoBehaviour
{
    public float timer;
    public Image _image;
    public bool IsPressed = false;

    public GameObject panel;

    public TextMeshProUGUI textPP;
    public TextMeshProUGUI textPP2;
    public TextMeshProUGUI textPP3;

    private void Update()
    {

        textPP.text = $"<sprite=1> {playerManager.Reduction_0(playerManager.prestigePointsTotal)}";
        textPP2.text = $"Bonus:\n {playerManager.Reduction_0(playerManager.prestigePointsTotal)}%";
        textPP3.text = $"Reset to lose all progress and get  <sprite=1> {playerManager.Reduction_0(playerManager.prestigePointsCurrent)}.\nEach  <sprite=1> increases instrument effectiveness by 1 % ";






        if (IsPressed == true)
        {
            timer += 1f * Time.deltaTime;
            if (timer > 3f)
            {
                timer = 0;
                ResetWorld();
            }
        }
        _image.fillAmount = 1f / 3f * timer;
    }


    public void ResetWorld()
    {
        playerManager.money = 0;
        playerManager.moneyTotal = 0;



        playerManager.incomeMoney = 0;

        playerManager.prestigePointsTotal += playerManager.prestigePointsCurrent;


        playerManager.currentLevel = 0;
        playerManager.currentLevelState = 0;


        playerManager.artColorLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        for(int i = 0; i < 10; i++)
        {
            playerManager.artColorBar[i] = playerManager.artColorBarMaxStart[i];
        }

        playerManager.upgradeLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        playerManager.artHp = new double[400];
        playerManager.artHpMax = new double[400];
        playerManager.artLive = new int[400];
        playerManager.artCount = 0;
        playerManager.artCountMax = 0;

        playerManager.xBuyTools = 0;

        playerManager.panelOn = 0;







        playerManager.UpdateUpgrade();
        playerManager.OpenPanelOn();

        playerManager.UpdateArt();





        timer = 0;
        IsPressed = false;

        panel.SetActive(false);
        //saveGame.save_gam();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

















    private void OnMouseDown()
    {
        IsPressed = true;
    }

    private void OnMouseUp()
    {
        timer = 0;
        IsPressed = false;
    }

    private void OnMouseExit()
    {
        timer = 0;
        IsPressed = false;
    }

}
