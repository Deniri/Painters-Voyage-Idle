using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class saveGame : MonoBehaviour
{

    private static Save sv = new Save();

    public static int save_on = 0;
    public static int load_on = 0;


    public static float save_time = 0f;
    public static float save_time_online = 0f;
    public static float load_time_online = 10f;


    //import export
    public static int amount_export_save = 0;
    public static string export_text = "";

    public static string save_string = "";


    private static int prov_amount;
    private static string[] all_slot = new string[5000];
    public static string import_string = "";


    //год мес€ц день час минута секунда
    public static int[] data_off = new int[] { 0, 0, 0, 0, 0, 0 };
    public static int[] data_off2 = new int[] { 0, 0, 0, 0, 0, 0 };
    public static int[] data_on = new int[] { 0, 0, 0, 0, 0, 0 };

    public static int[] mountD = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static int prosh_sec;
    public static int cur_sec;
    public static int mount_day;
    public static int mount_dayC;
    public static int sec_in_off;



    public static int on_off_save = 0;

    public static int import_compl = 0;






    void Awake()
    {
        if (save_on == 0)
        {
            if (PlayerPrefs.HasKey("Save"))
            {
                sv = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));

                load_gam();
            }
        }
    }




    private void Update()
    {
        save_time += 5f * Time.deltaTime;

        if (save_time >= 1)
        {
            save_time = 0f;


            save_gam();

        }

        save_time_online += 1f * Time.deltaTime;
        load_time_online += 1f * Time.deltaTime;





    }




    public static void save_gam()
    {
        //Debug.Log("Save game");


        sv.money = playerManager.money;
        sv.moneyTotal = playerManager.moneyTotal;

        sv.incomeMoney = playerManager.incomeMoney;

        sv.prestigePointsTotal = playerManager.prestigePointsTotal;
        sv.prestigePointsCurrent = playerManager.prestigePointsCurrent;


        sv.currentLevel = playerManager.currentLevel;
        sv.currentLevelMax = playerManager.currentLevelMax;
        sv.currentLevelState = playerManager.currentLevelState;

        for (int i = 0; i < 400; i++)
        {
            sv.artHp[i] = playerManager.artHp[i];
            sv.artHpMax[i] = playerManager.artHpMax[i];
            sv.artLive[i] = playerManager.artLive[i];
        }

        sv.artCount = playerManager.artCount;
        sv.artCountMax = playerManager.artCountMax;


        for (int i = 0; i < 10; i++)
        {
            sv.artColorLevel[i] = playerManager.artColorLevel[i];
            sv.artColorBar[i] = playerManager.artColorBar[i];
        }

        for (int i = 0; i < 50; i++)
        {
            sv.upgradeLevel[i] = playerManager.upgradeLevel[i];
        }


        sv.learnOn = playerManager.learnOn;
        sv.musicOnOff = playerManager.musicOnOff;




        PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));

    }

    public static void load_gam()
    {
        Debug.Log("Load game");

        save_on = 1;

        playerManager.money = sv.money;
        playerManager.moneyTotal = sv.moneyTotal;


        playerManager.incomeMoney = sv.incomeMoney;

        playerManager.prestigePointsTotal = sv.prestigePointsTotal;
        playerManager.prestigePointsCurrent = sv.prestigePointsCurrent;


        playerManager.currentLevel = sv.currentLevel;
        playerManager.currentLevelMax = sv.currentLevelMax;
        playerManager.currentLevelState = sv.currentLevelState;

        for(int i = 0; i < 400; i++)
        {
            playerManager.artHp[i] = sv.artHp[i];
            playerManager.artHpMax[i] = sv.artHpMax[i];
            playerManager.artLive[i] = sv.artLive[i];
        }
        
        playerManager.artCount = sv.artCount;
        playerManager.artCountMax = sv.artCountMax;


        for(int i = 0; i < 10; i++)
        {
            playerManager.artColorLevel[i] = sv.artColorLevel[i];
            playerManager.artColorBar[i] = sv.artColorBar[i];
        }

        for (int i = 0; i < 50; i++)
        {
            playerManager.upgradeLevel[i] = sv.upgradeLevel[i];
        }




        playerManager.learnOn = sv.learnOn;
        playerManager.musicOnOff = sv.musicOnOff;

        if (sv.money > 0f)
        {
            load_on = 1;
        }

    }













    [Serializable]
    public class Save
    {

        public double money = 0;
        public double moneyTotal = 0;

        public double incomeMoney = 0;

        public double prestigePointsTotal = 0;
        public double prestigePointsCurrent = 0;


        public int currentLevel = 0;
        public int currentLevelMax = 0;
        public int currentLevelState = 0;

        public double[] artHp = new double[400];
        public double[] artHpMax = new double[400];
        public int[] artLive = new int[400];
        public int artCount = 0;
        public int artCountMax = 0;


        public int[] artColorLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        
        public float[] artColorBar = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


        public int[] upgradeLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };




        public int learnOn = 0;
        public int musicOnOff = 0;

    }


}
