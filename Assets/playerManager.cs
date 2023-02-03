using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Math = System.Math;

public class playerManager : MonoBehaviour
{


    public static double money = 0d;
    public static double moneyTotal = 0d;
    public static double incomeMoney = 0;

    public static double prestigePointsTotal = 0;
    public static double prestigePointsCurrent = 0;


    public static int currentLevel = 0;
    public static int currentLevelMax = 0;
    public static int currentLevelState = 0;

    public static double[] artHp = new double[400];
    public static double[] artHpMax = new double[400];
    public static int[] artLive = new int[400];
    public static int artCount = 0;
    public static int artCountMax = 0;


    public static int colorAmount = 10;
    public static int[] artColorLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] artColorLevelx25 = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] artColorDmg = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] artColorDmgStart = new double[] { 1, 10, 75, 375, 1875, 9375, 46875, 234375, 1171875, 5859375, };
    public static double[] artColorDmgPerLevel = new double[] { 1, 10, 75, 375, 1875, 9375, 46875, 234375, 1171875, 5859375, };
    public static double[] artColorCost = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] artColorCostStart = new double[] { 10, 100, 720, 6480, 58320, 524880, 4723920, 42515280, 382637520, 3443737680, };
    public static double[] artColorCostMnoj = new double[] { 1.15d, 1.155d, 1.16d, 1.165d, 1.17d, 1.175d, 1.18d, 1.185d, 1.19d, 1.195d, };
    public static float[] artColorSpeed = new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
    public static float[] artColorBar = new float[] { 2, 4, 8, 12, 24, 36, 72, 98, 144, 180, };
    public static float[] artColorBarMax = new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
    public static float[] artColorBarMaxStart = new float[] { 2, 4, 8, 12, 24, 36, 72, 98, 144, 180, };
    public static double[] artColorCritC = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] artColorCritM = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


    public static int upgradeAmount = 50;
    public static int[] upgradeLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] upgradeCost = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] upgradeCostStart = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
    public static double[] upgradeCostMnoj = new double[] { 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, 3.5d, };
    public static double[] upgradePower = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

    public static int[] upgradeDost = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static int[] upgradeSort = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


    public static int learnOn = 0;
    public static int musicOnOff = 0;

    public static int xBuyTools = 0;
    public static int[] xBuy = new int[] { 1, 10, 25, 50 };

    public static int panelOn = 0;

    public static artCanvas _artCanvas;
    public static panelON[] _panelON = new panelON[5];


    public static art _art;
    private float timer = 0f;

    private bool onOff = true;
    private bool onOff2 = true;
    public GameObject vosk;

    public static float adSpeedTimer = 0f;
    public static bool adSpeedActive = false;

    private void Start()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");


        //стоимость апгрейдов
        for (int i = 0; i < 10; i++)
        {
            upgradeCostStart[i] = artColorCostStart[i] * 100;
            upgradeCostStart[i + 10] = artColorCostStart[i] * 500;
            upgradeCostStart[i + 20] = artColorCostStart[i] * 250;
            upgradeCostStart[i + 30] = artColorCostStart[i] * 250;
            upgradeCostStart[i + 40] = artColorCostStart[i] * 200;
        }




        UpdateUpgrade();
        OpenPanelOn();

        if(saveGame.load_on == 0)
            UpdateArt();
        else
        {
            _art.UpdateArt();
        }

       
    }





    private void FixedUpdate()
    {


        if(adSpeedTimer > 0)
        {
            money += incomeMoney * 1.5d * Time.deltaTime;
            moneyTotal += incomeMoney * 1.5d * Time.deltaTime;
        }
        else
        {
            money += incomeMoney * Time.deltaTime;
            moneyTotal += incomeMoney * Time.deltaTime;
        }
        

        if (adSpeedTimer > 0f)
        {
            adSpeedTimer -= 1f * Time.deltaTime;
            if (adSpeedTimer <= 0f)
                adSpeedActive = false;
        }
            


        //Prestige points
        prestigePointsCurrent = Math.Floor(Math.Pow(moneyTotal / 20000d, 1d / 1.01d));

        //определение цели цветов
        if (currentLevelState == 1)
        {
            for (int i = 0; i < colorAmount; i++)
            {
                if (artColorLevel[i] > 0 && artCount > 0)
                {
                    artColorBar[i] -= artColorSpeed[i] * Time.deltaTime;
                    if (artColorBar[i] <= 0)
                    {
                        artColorBar[i] = artColorBarMax[i];

                        //выбираем цель
                        if(currentLevel == 0 && artCount == artCountMax)
                        {
                            _artCanvas.StartAnimationColor(i, 12);
                        }
                        else
                        {
                            _artCanvas.StartAnimationColor(i, Random.Range(0, artCount));
                        }
                        
                    }
                }
            }
            //конец
            if(currentLevelState == 1 && artCount <= 0)
            {
                currentLevelState = 2;
                timer = 0f;
                currentLevel += 1;
                if (currentLevelMax < currentLevel)
                    currentLevelMax = currentLevel;
                _art.EndArt();
            }
        }
        if(currentLevelState == 2)
        {
            timer += Time.deltaTime;
            if(timer >= 3f)
            {
                UpdateArt();
            }
        }



        onOff = false;
        for (int i = 0; i < 50; i++)
        {
            if(money >= upgradeCost[i])
            {
                onOff = true;
            }
        }
        if(onOff == true)
        {
            if(onOff2 == false)
            {
                vosk.gameObject.SetActive(true);
                onOff2 = true;
            }
        }
        else
        {
            if (onOff2 == true)
            {
                vosk.gameObject.SetActive(false);
                onOff2 = false;
            }
        }

        



    }




    public static void UpdateColorStats()
    {
        for(int i = 0; i < colorAmount; i++)
        {
            //цена 
            artColorCost[i] = artColorCostStart[i] * Math.Pow(artColorCostMnoj[i], artColorLevel[i]);
            artColorCost[i] = (Math.Pow(artColorCostMnoj[i], xBuy[xBuyTools]) - 1d) / (artColorCostMnoj[i] - 1d) * artColorCost[i];
            artColorCost[i] = Math.Round(artColorCost[i]);

            if (i == 0 && artColorLevel[i] == 0)
                artColorCost[i] = 0;

            //апгрейд
            artColorCost[i] *= upgradePower[i + 20];
            

            //урон
            artColorDmg[i] = artColorDmgStart[i] + artColorDmgPerLevel[i] * (artColorLevel[i] - 1);
            //апгрейд
            artColorDmg[i] *= upgradePower[i];
            //x25
            artColorDmg[i] *= Math.Pow(2, artColorLevel[i] / 25);
            //престиж
            artColorDmg[i] *= prestigePointsTotal / 100d + 1;

            //крит шанс
            artColorCritC[i] = 0d;
            //апгрейд
            artColorCritC[i] += upgradePower[i + 30];

            //сила крита
            artColorCritM[i] = 1.5d;
            //апгрейд
            artColorCritM[i] += upgradePower[i + 40];

        }
    }

    public static void UpdateUpgrade()
    {
        for (int i = 0; i < upgradeAmount; i++)
        {
            //цена
            upgradeCost[i] = upgradeCostStart[i] * Math.Pow(upgradeCostMnoj[i], upgradeLevel[i]);

            //урон
            if (i >= 0 && i < 10)
            {
                upgradePower[i] = 1d * Math.Pow(2d, upgradeLevel[i]);
            }
            //скорость
            if (i >= 10 && i < 20)
            {
                upgradePower[i] = 1d * Math.Pow(0.85d, upgradeLevel[i]);
            }
            //стоимость
            if (i >= 20 && i < 30)
            {
                upgradePower[i] = 1d * Math.Pow(0.85d, upgradeLevel[i]);
            }
            //крит шанс
            if (i >= 30 && i < 40)
            {
                upgradePower[i] = upgradeLevel[i] * 3;
            }
            //крит сила
            if (i >= 40 && i < 50)
            {
                upgradePower[i] = upgradeLevel[i] * 0.15d;
            }
        }


        //доступ
        for (int i = 0; i < 10; i++)
        {
            if(artColorLevel[i] > 0)
            {
                upgradeDost[i] = 1;
                upgradeDost[i + 10] = 1;
                upgradeDost[i + 20] = 1;
                upgradeDost[i + 30] = 1;
                upgradeDost[i + 40] = 1;
            }
            else
            {
                upgradeDost[i] = 0;
                upgradeDost[i + 10] = 0;
                upgradeDost[i + 20] = 0;
                upgradeDost[i + 30] = 0;
                upgradeDost[i + 40] = 0;
            }
        }


        //обнуление сортировки
        for (int i = 0; i < upgradeAmount; i++)
        {
            upgradeSort[i] = -1;
        }
        //сортировка
        for (int i = 0; i < upgradeAmount; i++)
        {
            if(upgradeDost[i] == 1)
            {
                for(int i2 = 0; i2 < upgradeAmount; i2++)
                {
                    if(upgradeSort[i2] == -1)
                    {
                        upgradeSort[i2] = i;
                        break;
                    }
                    else
                    {
                        if(upgradeCost[i] < upgradeCost[upgradeSort[i2]])
                        {
                            for(int i3 = upgradeAmount - 2; i3 >= i2; i3--)
                            {
                                upgradeSort[i3 + 1] = upgradeSort[i3];
                            }
                            upgradeSort[i2] = i;
                            break;
                        }
                    }
                }
            }
        }




        UpdateColorStats();
        UpdateTimerTools();
    }




    public static void UpdateArtHp()
    {
        for(int i = 0; i < 400; i++)
        {
            if(artCanvas._allFrameArt[i].isActiveAndEnabled == true)
            {
                artHpMax[i] = Math.Round((1d + 10d * currentLevel) * Math.Pow(1.20d, currentLevel));
                if (currentLevel >= 10)
                    artHpMax[i] *= 1.5d;
                if (currentLevel >= 20)
                    artHpMax[i] *= 2d;
                artHp[i] = artHpMax[i];
            }
        }
        //заполняем массив с целями
        artCount = 0;
        for (int i = 0; i < 400; i++)
        {
            if (artHp[i] > 0)
            {
                artLive[artCount] = i;
                artCount += 1;
            }
        }
        artCountMax = artCount;
    }
    public static void UpdateArtHpCur()
    {
        for(int a = 0; a < artCount; a++)
        {
            if (artHp[artLive[a]] <= 0)
            {
                artCanvas._allFrameArt[artLive[a]].gameObject.SetActive(false);
                for (int i = a; i < artCount - 1; i++)
                {
                    artLive[i] = artLive[i + 1];
                }
                artCount -= 1;
                a = 0;
                incomeMoney += (currentLevel / 10d + 0.1);
            }
        }
        
    }



    public static void UpdateTimerTools()
    {
        for(int i = 0; i < 10; i++)
        {
            artColorBarMax[i] = artColorBarMaxStart[i];
            //апгрейд
            artColorBarMax[i] *= (float)upgradePower[i + 10];
            if (artColorBar[i] > artColorBarMax[i])
                artColorBar[i] = artColorBarMax[i];
        }
    }




    public static void OpenPanelOn()
    {
        for(int i = 0; i < 4; i++)
        {
            if(panelOn == i)
                _panelON[i].gameObject.SetActive(true);
            else
                _panelON[i].gameObject.SetActive(false);
        }
    }



    public static void UpdateArt()
    {
        _art.UpdateArt();
        _artCanvas.AllFrameArtOnCanvasPosition();
        UpdateArtHp();
        currentLevelState = 1;
    }




    //временное сокращение
    #region
    public static string Timer00(float timer)
    {
        string ret = "";
        float min = Mathf.Floor(timer / 60f);
        float sec = Mathf.Round(timer - min * 60f);


        if (min < 10f)
            ret += "0";
        ret += min + ":";
        if (sec < 10f)
            ret += "0";
        ret += sec;

        return (ret);
    }
    #endregion

    //сокращение чисел
    #region
    public static int notation = 0;

    //Reduction 0
    private static string[] sokr = new string[] { "K", "M", "B", "T", "aa", "ab", "ac", "ad", "ae", "af", "ag", "ah", "ai", "aj", "ak", "al", "am", "an", "ao", "ap", "aq", "ar", "as", "at", "au", "av", "aw", "ax", "ay", "az", "ba", "bb", "bc", "bd", "be", "bf", "bg", "bh", "bi", "bj", "bk", "bl", "bm", "bn", "bo", "bp", "bq", "br", "bs", "bt", "bu", "bv", "bw", "bx", "by", "bz", "ca", "cb", "cc", "cd", "ce", "cf", "cg", "ch", "ci", "cj", "ck", "cl", "cm", "cn", "co", "cp", "cq", "cr", "cs", "ct", "cu", "cv", "cw", "cx", "cy", "cz", "da", "db", "dc", "dd", "de", "df", "dg", "dh", "di", "dj", "dk", "dl", "dm", "dn", "do", "dp", "dq", "dr", "ds", "dt" };
    public static string Reduction_0(double costs)
    {
        string ret = "Over";

        //alf
        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + (sokr[prov_n]);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }

        //scientific
        if (notation == 1)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 10;
                    prov_n = i;
                }
                //ret = Math.Floor();
                ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + "e" + (prov_n + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }
        //scientific
        if (notation == 2)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                int prov_eng = -1;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                //for eng
                double prov2 = 1000000;
                for (int i = 0; costs >= prov2; i++)
                {
                    prov2 *= 10;
                    prov_eng += 1;
                    if (prov_eng > 2)
                        prov_eng = 0;
                }

                if (prov_eng == 0)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N3") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 1)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 2)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + "e" + (prov_n * 3 + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }






        return (ret);
    }
    public static string Reduction_1(double costs)
    {
        string ret = "Over";

        //alf
        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("n1");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + (sokr[prov_n]);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }

        //scientific
        if (notation == 1)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 10;
                    prov_n = i;
                }
                //ret = Math.Floor();
                ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + "e" + (prov_n + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }
        //scientific
        if (notation == 2)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                int prov_eng = -1;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                //for eng
                double prov2 = 1000000;
                for (int i = 0; costs >= prov2; i++)
                {
                    prov2 *= 10;
                    prov_eng += 1;
                    if (prov_eng > 2)
                        prov_eng = 0;
                }

                if (prov_eng == 0)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N3") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 1)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 2)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + "e" + (prov_n * 3 + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }






        return (ret);
    }
    public static string Reduction_2(double costs)
    {
        string ret = "Over";

        //alf
        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("n2");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + (sokr[prov_n]);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }

        //scientific
        if (notation == 1)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 10;
                    prov_n = i;
                }
                //ret = Math.Floor();
                ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + "e" + (prov_n + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }
        //scientific
        if (notation == 2)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                int prov_eng = -1;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                //for eng
                double prov2 = 1000000;
                for (int i = 0; costs >= prov2; i++)
                {
                    prov2 *= 10;
                    prov_eng += 1;
                    if (prov_eng > 2)
                        prov_eng = 0;
                }

                if (prov_eng == 0)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N3") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 1)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 2)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + "e" + (prov_n * 3 + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }






        return (ret);
    }
    #endregion










}
