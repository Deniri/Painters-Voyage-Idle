using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artCanvas : MonoBehaviour
{

    public frameArt _frameArtPrefab;
    public static frameArt[] _allFrameArt = new frameArt[400];
    private int frameArtAmount = 400;
    private Vector3 posXYZ;

    public color0 _color0Prefab;
    public static color0[] _allColor0 = new color0[50];
    private int color0Cur = -1;

    public color1 _color1Prefab;
    public static color1[] _allColor1 = new color1[50];
    private int color1Cur = -1;

    public color2 _color2Prefab;
    public static color2[] _allColor2 = new color2[50];
    private int color2Cur = -1;

    public color3 _color3Prefab;
    public static color3[] _allColor3 = new color3[50];
    private int color3Cur = -1;

    public color4 _color4Prefab;
    public static color4[] _allColor4 = new color4[50];
    private int color4Cur = -1;

    public color5 _color5Prefab;
    public static color5[] _allColor5 = new color5[50];
    private int color5Cur = -1;

    public color6 _color6Prefab;
    public static color6[] _allColor6 = new color6[50];
    private int color6Cur = -1;

    public color7 _color7Prefab;
    public static color7[] _allColor7 = new color7[50];
    private int color7Cur = -1;

    public color8 _color8Prefab;
    public static color8[] _allColor8 = new color8[100];
    private int color8Cur = -1;

    public color9 _color9Prefab;
    public static color9[] _allColor9 = new color9[50];
    private int color9Cur = -1;






    public static int artCanvasScale = 5;
    private float[] startPosX = new float[] { -1.28f, -1.44f, -1.52f };
    private float[] startPosY = new float[] { 1.25f, 1.41f, 1.49f };
    public Vector3 scaleArt = new Vector3(1f, 1f, 1f);


    private void Awake()
    {
        playerManager._artCanvas = this;
        CreateAllPrefab();
        
    }

    private void Start()
    {
        AllFrameArtOnCanvasPosition();
    }



    //создание префабов арта всех
    public void CreateAllPrefab()
    {
        for(int i = 0; i < frameArtAmount; i++)
        {
            _allFrameArt[i] = Instantiate(_frameArtPrefab, this.transform);
            _allFrameArt[i].number = i;
        }
    }

    //положение префабов на полотне и их активность
    public void AllFrameArtOnCanvasPosition()
    {
        
        if (playerManager.currentLevel < 10)
            artCanvasScale = 5;
        if (playerManager.currentLevel >= 10 && playerManager.currentLevel < 20)
            artCanvasScale = 10;
        if (playerManager.currentLevel >= 20)
            artCanvasScale = 20;

        for (int i = 0; i < frameArtAmount; i++)
        {
            if(i - i / 20 * 20 < artCanvasScale && i / 20 < artCanvasScale)
            {
                _allFrameArt[i].gameObject.SetActive(true);

                _allFrameArt[i].scaleArt = 20 / artCanvasScale;
                _allFrameArt[i].transform.localScale = scaleArt;
            }
            else
            {
                _allFrameArt[i].gameObject.SetActive(false);
            }

            //стартовая позиция
            if(artCanvasScale == 5)
            {
                posXYZ.x = startPosX[0];
                posXYZ.y = startPosY[0];
            }
            if (artCanvasScale == 10)
            {
                posXYZ.x = startPosX[1];
                posXYZ.y = startPosY[1];
            }
            if (artCanvasScale == 20)
            {
                posXYZ.x = startPosX[2];
                posXYZ.y = startPosY[2];
            }

            //перемещение обекта
            posXYZ.x += (0.16f * (20 / artCanvasScale)) * (i % 20);
            posXYZ.y -= (0.16f * (20 / artCanvasScale)) * (i / 20);
            _allFrameArt[i].transform.localPosition = posXYZ;
        }

        
    }


    //призыв анимации цветов
    public void StartAnimationColor(int num, int target)
    {
        int targetCur = playerManager.artLive[target];

        //красный
        if (num == 0)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor0[i] == null)
                {
                    _allColor0[i] = Instantiate(_color0Prefab, this.transform);
                    color0Cur = i;
                    break;
                }
                else
                {
                    if (_allColor0[i].isActiveAndEnabled == false)
                    {
                        _allColor0[i].gameObject.SetActive(true);
                        color0Cur = i;
                        break;
                    }
                }
            }
            //рандомим вращение
            int forw = Random.Range(0, 4);
            if (forw == 0)
                _allColor0[color0Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
            if (forw == 1)
                _allColor0[color0Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
            if (forw == 2)
                _allColor0[color0Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
            if (forw == 3)
                _allColor0[color0Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
            //задаём позицию
            _allColor0[color0Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor0[color0Cur].transform.localScale = scaleArt;

            //наносим урон
            _allColor0[color0Cur].target = targetCur;


        }
        //оранжевый
        if (num == 1)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor1[i] == null)
                {
                    _allColor1[i] = Instantiate(_color1Prefab, this.transform);
                    color1Cur = i;
                    break;
                }
                else
                {
                    if (_allColor1[i].isActiveAndEnabled == false)
                    {
                        _allColor1[i].gameObject.SetActive(true);
                        color1Cur = i;
                        break;
                    }
                }
            }

            

            //определяем движение позиции
            int forw = Random.Range(0,4);
            //вверх
            if (forw == 0 && targetCur < artCanvasScale)
            {
                targetCur += 20;
            }
            if (forw == 1 && targetCur % 20 == artCanvasScale - 1)
            {
                targetCur -= 1;
            }
            if (forw == 2 && targetCur > artCanvasScale * artCanvasScale - artCanvasScale - 1)
            {
                targetCur -= 20;
            }
            if (forw == 3 && targetCur % 20 == 0)
            {
                targetCur += 1;
            }


            //наносим урон
            _allColor1[color1Cur].target = targetCur;

            if (forw == 0)
            {
                _allColor1[color1Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
                if(playerManager.artHp[targetCur - 20] > 0)
                {
                    _allColor1[color1Cur].target2 = targetCur - 20;
                }
            } 
            if (forw == 1)
            {
                _allColor1[color1Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
                if(playerManager.artHp[targetCur + 1] > 0)
                {
                    _allColor1[color1Cur].target2 = targetCur + 1;
                }
            }  
            if (forw == 2)
            {
                _allColor1[color1Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
                if(playerManager.artHp[targetCur + 20] > 0)
                {
                    _allColor1[color1Cur].target2 = targetCur + 20;
                }
                
            }
            if (forw == 3)
            {
                _allColor1[color1Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
                if(playerManager.artHp[targetCur - 1] > 0)
                {
                    _allColor1[color1Cur].target2 = targetCur - 1;
                }
            }

            //задаём позицию
            _allColor1[color1Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor1[color1Cur].transform.localScale = scaleArt;

        }
        //салатовый
        if (num == 2)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor2[i] == null)
                {
                    _allColor2[i] = Instantiate(_color2Prefab, this.transform);
                    color2Cur = i;
                    break;
                }
                else
                {
                    if (_allColor2[i].isActiveAndEnabled == false)
                    {
                        _allColor2[i].gameObject.SetActive(true);
                        color2Cur = i;
                        break;
                    }
                }
            }

            //определяем движение позиции
            int forw = Random.Range(0, 4);
            //вверх право
            if (forw == 0)
            {
                if((targetCur < artCanvasScale && targetCur % 20 == 0) || (targetCur / 20 == artCanvasScale - 1 && targetCur - targetCur / 20 * 20 == artCanvasScale - 1))
                {
                    forw = 1;
                }
                else
                {
                    if (targetCur < artCanvasScale || targetCur % 20 == artCanvasScale - 1)
                        targetCur += 19;
                }
            }
            //низ право
            if (forw == 1)
            {
                if((targetCur - targetCur / 20 * 20 == artCanvasScale - 1 && targetCur < artCanvasScale) || (targetCur / 20 == artCanvasScale - 1 && targetCur - targetCur / 20 * 20 == 0))
                {
                    forw = 2;
                }
                else
                {
                    if(targetCur - targetCur / 20 * 20 == artCanvasScale - 1 || targetCur / 20 == artCanvasScale - 1)
                        targetCur -= 21;
                }
            }
            //лево низ
            if (forw == 2)
            {
                if((targetCur - targetCur / 20 * 20 == 0 && targetCur < artCanvasScale) || (targetCur / 20 == artCanvasScale - 1 && targetCur - targetCur / 20 * 20 == artCanvasScale - 1))
                {
                    forw = 3;
                }
                else
                {
                    if(targetCur - targetCur / 20 * 20 == 0 || targetCur / 20 == artCanvasScale - 1)
                        targetCur -= 19;
                }
                
            }
            //лево верх
            if (forw == 3)
            {
                if((targetCur < artCanvasScale && targetCur - targetCur / 20 * 20 == artCanvasScale - 1))
                {
                    forw = 0;
                    targetCur += 19;
                }
                else
                {
                    if(targetCur - targetCur / 20 * 20 == 0 && targetCur / 20 == artCanvasScale - 1)
                    {
                        forw = 0;
                    }
                    else
                    {
                        if (targetCur < artCanvasScale || targetCur - targetCur / 20 * 20 == 0)
                            targetCur += 21;
                    }
                } 
            }


            //наносим урон
            _allColor2[color2Cur].target = targetCur;

            if (forw == 0)
            {
                _allColor2[color2Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
                if (playerManager.artHp[targetCur - 19] > 0)
                {
                    _allColor2[color2Cur].target2 = targetCur - 19;
                }
            }
            if (forw == 1)
            {
                _allColor2[color2Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
                if (playerManager.artHp[targetCur + 21] > 0)
                {
                    _allColor2[color2Cur].target2 = targetCur + 21;
                }
            }
            if (forw == 2)
            {
                _allColor2[color2Cur].transform.rotation = Quaternion.Euler(0, 0, -180);
                if (playerManager.artHp[targetCur + 19] > 0)
                {
                    _allColor2[color2Cur].target2 = targetCur + 19;
                }

            }
            if (forw == 3)
            {
                _allColor2[color2Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
                if (playerManager.artHp[targetCur - 21] > 0)
                {
                    _allColor2[color2Cur].target2 = targetCur - 21;
                }
            }


            //задаём позицию
            _allColor2[color2Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor2[color2Cur].transform.localScale = scaleArt;


        }
        //голубой
        if (num == 3)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor3[i] == null)
                {
                    _allColor3[i] = Instantiate(_color3Prefab, this.transform);
                    color3Cur = i;
                    break;
                }
                else
                {
                    if (_allColor3[i].isActiveAndEnabled == false)
                    {
                        _allColor3[i].gameObject.SetActive(true);
                        color3Cur = i;
                        break;
                    }
                }
            }


            //наносим урон
            _allColor3[color3Cur].target = targetCur;
            //задаём позицию
            _allColor3[color3Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor3[color3Cur].transform.localScale = scaleArt;

            //определяем движение позиции
            int forw = 0;
            int[] queue = new int[] { -1, -1, -1, -1};
            //верх
            if (targetCur >= 20)
            {
                queue[forw] = targetCur - 20;
                forw += 1;
            }
            if (targetCur - targetCur / artCanvasScale * artCanvasScale != artCanvasScale - 1)
            {
                queue[forw] = targetCur + 1;
                forw += 1;
            }
            if (targetCur < 20 * (artCanvasScale - 1))
            {
                queue[forw] = targetCur + 20;
                forw += 1;
            }
            if (targetCur - targetCur / 20 * 20 > 0)
            {
                queue[forw] = targetCur - 1;
                forw += 1;
            }
            //создание дупликатов
            for (int i = 0; i < forw; i++)
            {
                int ran = Random.Range(0, forw);
                int ran2 = queue[i];
                queue[i] = queue[ran];
                queue[ran] = ran2;
            }
            ForColor3(queue[0], num);
            ForColor3(queue[1], num);



            


        }
        //фиолетовый
        if (num == 4)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor4[i] == null)
                {
                    _allColor4[i] = Instantiate(_color4Prefab, this.transform);
                    color4Cur = i;
                    break;
                }
                else
                {
                    if (_allColor4[i].isActiveAndEnabled == false)
                    {
                        _allColor4[i].gameObject.SetActive(true);
                        color4Cur = i;
                        break;
                    }
                }
            }

            //определяем исключения для свдвига
            if (targetCur < 20)
                targetCur += 20;
            if (targetCur - targetCur / 20 * 20 == artCanvasScale - 1)
                targetCur -= 1;
            //задаём позицию
            _allColor4[color4Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor4[color4Cur].transform.localScale = scaleArt;

            //наносим урон
            _allColor4[color4Cur].target = targetCur;
            _allColor4[color4Cur].target2 = targetCur - 20;
            _allColor4[color4Cur].target3 = targetCur + 1;
            _allColor4[color4Cur].target4 = targetCur - 19;
            

        }
        //розовый
        if (num == 5)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor5[i] == null)
                {
                    _allColor5[i] = Instantiate(_color5Prefab, this.transform);
                    color5Cur = i;
                    break;
                }
                else
                {
                    if (_allColor5[i].isActiveAndEnabled == false)
                    {
                        _allColor5[i].gameObject.SetActive(true);
                        color5Cur = i;
                        break;
                    }
                }
            }


            //определяем движение позиции
            int forw = 0;
            int[] queue = new int[] { -1, -1, -1, -1 };
            //верх
            if (targetCur >= 20)
            {
                queue[forw] = targetCur - 20;
                forw += 1;
            }
            if (targetCur - targetCur / artCanvasScale * artCanvasScale != artCanvasScale - 1)
            {
                queue[forw] = targetCur + 1;
                forw += 1;
            }
            if (targetCur < 20 * (artCanvasScale - 1))
            {
                queue[forw] = targetCur + 20;
                forw += 1;
            }
            if (targetCur - targetCur / 20 * 20 > 0)
            {
                queue[forw] = targetCur - 1;
                forw += 1;
            }
            int ran = Random.Range(0, forw);
            if (targetCur - queue[ran] == 20)
            {
                _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            if (targetCur - queue[ran] == -1)
            {
                _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (targetCur - queue[ran] == -20)
            {
                _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            if (targetCur - queue[ran] == 1)
            {
                _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
            }

            //задаём позицию
            _allColor5[color5Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor5[color5Cur].transform.localScale = scaleArt;

            //наносим урон
            _allColor5[color5Cur].target = targetCur;
            _allColor5[color5Cur].targetNext = queue[ran];
            _allColor5[color5Cur].count = 3;

        }
        //жёлтый
        if (num == 6)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor6[i] == null)
                {
                    _allColor6[i] = Instantiate(_color6Prefab, this.transform);
                    color6Cur = i;
                    break;
                }
                else
                {
                    if (_allColor6[i].isActiveAndEnabled == false)
                    {
                        _allColor6[i].gameObject.SetActive(true);
                        color6Cur = i;
                        break;
                    }
                }
            }

            //рандомим вращение
            int forw = Random.Range(0, 4);
            if (forw == 0)
                _allColor6[color6Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
            if (forw == 1)
                _allColor6[color6Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
            if (forw == 2)
                _allColor6[color6Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
            if (forw == 3)
                _allColor6[color6Cur].transform.rotation = Quaternion.Euler(0, 0, -90);

            //задаём позицию
            _allColor6[color6Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor6[color6Cur].transform.localScale = scaleArt;

            //наносим урон
            _allColor6[color6Cur].target = targetCur;


        }
        //синий
        if (num == 7)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor7[i] == null)
                {
                    _allColor7[i] = Instantiate(_color7Prefab, this.transform);
                    color7Cur = i;
                    break;
                }
                else
                {
                    if (_allColor7[i].isActiveAndEnabled == false)
                    {
                        _allColor7[i].gameObject.SetActive(true);
                        color7Cur = i;
                        break;
                    }
                }
            }

            //рандомим вращение
            int forw = Random.Range(0, 4);
            if (forw == 0)
            {
                _allColor7[color7Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
                //определяем исключения для свдвига
                if (targetCur < 20)
                    targetCur += 20;
                if (targetCur - targetCur / 20 * 20 == artCanvasScale - 1)
                    targetCur -= 2;
                if (targetCur - targetCur / 20 * 20 == artCanvasScale - 2)
                    targetCur -= 1;

                //наносим урон
                _allColor7[color7Cur].target = targetCur;
                _allColor7[color7Cur].target2 = targetCur - 20;
                _allColor7[color7Cur].target3 = targetCur + 1;
                _allColor7[color7Cur].target4 = targetCur - 19;
                _allColor7[color7Cur].target5 = targetCur + 2;
                _allColor7[color7Cur].target6 = targetCur - 18;
            }
            if (forw == 1)
            {
                _allColor7[color7Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
                //определяем исключения для свдвига
                if (targetCur < 20)
                    targetCur += 40;
                if (targetCur < 40)
                    targetCur += 20;
                if(targetCur - targetCur / 20 * 20 == 0)
                    targetCur += 1;
                //наносим урон
                _allColor7[color7Cur].target = targetCur;
                _allColor7[color7Cur].target2 = targetCur - 1;
                _allColor7[color7Cur].target3 = targetCur - 20;
                _allColor7[color7Cur].target4 = targetCur - 21;
                _allColor7[color7Cur].target5 = targetCur - 40;
                _allColor7[color7Cur].target6 = targetCur - 41;
            }
            if (forw == 2)
            {
                _allColor7[color7Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
                //определяем исключения для свдвига
                if (targetCur - targetCur / 20 * 20 == 0)
                    targetCur += 2;
                if (targetCur - targetCur / 20 * 20 == 1)
                    targetCur += 1;
                if (targetCur >= artCanvasScale * 20 - 20)
                    targetCur -= 20;

                //наносим урон
                _allColor7[color7Cur].target = targetCur;
                _allColor7[color7Cur].target2 = targetCur + 20;
                _allColor7[color7Cur].target3 = targetCur - 1;
                _allColor7[color7Cur].target4 = targetCur + 19;
                _allColor7[color7Cur].target5 = targetCur - 2;
                _allColor7[color7Cur].target6 = targetCur + 18;
            }
            if (forw == 3)
            {
                _allColor7[color7Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
                //определяем исключения для свдвига
                if (targetCur >= artCanvasScale * 20 - 20)
                    targetCur -= 40;
                if (targetCur >= artCanvasScale * 20 - 40)
                    targetCur -= 20;
                if (targetCur - targetCur / 20 * 20 == artCanvasScale - 1)
                    targetCur -= 1;

                //наносим урон
                _allColor7[color7Cur].target = targetCur;
                _allColor7[color7Cur].target2 = targetCur + 1;
                _allColor7[color7Cur].target3 = targetCur + 20;
                _allColor7[color7Cur].target4 = targetCur + 21;
                _allColor7[color7Cur].target5 = targetCur + 40;
                _allColor7[color7Cur].target6 = targetCur + 41;
            }
            
            
            //задаём позицию
            _allColor7[color7Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor7[color7Cur].transform.localScale = scaleArt;

            
            





        }
        //лаймовый
        if (num == 8)
        {
            for (int i = 0; i < 100; i++)
            {
                if (_allColor8[i] == null)
                {
                    _allColor8[i] = Instantiate(_color8Prefab, this.transform);
                    color8Cur = i;
                    break;
                }
                else
                {
                    if (_allColor8[i].isActiveAndEnabled == false)
                    {
                        _allColor8[i].gameObject.SetActive(true);
                        color8Cur = i;
                        break;
                    }
                }
            }
            //рандомим вращение
            int forw = Random.Range(0, 4);
            if (forw == 0)
                _allColor8[color8Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
            if (forw == 1)
                _allColor8[color8Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
            if (forw == 2)
                _allColor8[color8Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
            if (forw == 3)
                _allColor8[color8Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
            //задаём позицию
            _allColor8[color8Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor8[color8Cur].transform.localScale = scaleArt;

            //наносим урон
            _allColor8[color8Cur].target = targetCur;


            //создаём ещё 6 копий
            for(int i = 0; i < 6; i++)
            {
                ForColor8(playerManager.artLive[Random.Range(0, playerManager.artCount)], num);
            }
            
        }
        //лиловый
        if (num == 9)
        {
            for (int i = 0; i < 50; i++)
            {
                if (_allColor9[i] == null)
                {
                    _allColor9[i] = Instantiate(_color9Prefab, this.transform);
                    color9Cur = i;
                    break;
                }
                else
                {
                    if (_allColor9[i].isActiveAndEnabled == false)
                    {
                        _allColor9[i].gameObject.SetActive(true);
                        color9Cur = i;
                        break;
                    }
                }
            }

            if(targetCur < 20)
            {
                targetCur += 20;
            }
            if (targetCur - targetCur / 20 * 20 == artCanvasScale - 1)
            {
                targetCur -= 1;
            }

            _allColor9[color9Cur].transform.rotation = Quaternion.Euler(0, 0, 0);

            //наносим урон
            _allColor9[color9Cur].target = targetCur;
            _allColor9[color9Cur].targetNext = targetCur;
            _allColor9[color9Cur].count = 4;

            //задаём позицию
            _allColor9[color9Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
            //задаём размер
            scaleArt.x = 20 / artCanvasScale;
            scaleArt.y = 20 / artCanvasScale;
            _allColor9[color9Cur].transform.localScale = scaleArt;
        }



    }






    //создание дополнительной анимации
    public void ForColor3(int targetCur, int num)
    {
        for (int i = 0; i < 50; i++)
        {
            if (_allColor3[i] == null)
            {
                _allColor3[i] = Instantiate(_color3Prefab, this.transform);
                color3Cur = i;
                break;
            }
            else
            {
                if (_allColor3[i].isActiveAndEnabled == false)
                {
                    _allColor3[i].gameObject.SetActive(true);
                    color3Cur = i;
                    break;
                }
            }
        }

        //задаём позицию
        _allColor3[color3Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
        //задаём размер
        scaleArt.x = 20 / artCanvasScale;
        scaleArt.y = 20 / artCanvasScale;
        _allColor3[color3Cur].transform.localScale = scaleArt;

        //наносим урон
        _allColor3[color3Cur].target = targetCur;
    }
    public void ForColor5(int targetCur, int num)
    {
        for (int i = 0; i < 50; i++)
        {
            if (_allColor5[i] == null)
            {
                _allColor5[i] = Instantiate(_color5Prefab, this.transform);
                color5Cur = i;
                break;
            }
            else
            {
                if (_allColor5[i].isActiveAndEnabled == false)
                {
                    _allColor5[i].gameObject.SetActive(true);
                    color5Cur = i;
                    break;
                }
            }
        }

        //определяем движение позиции
        int forw = 0;
        int[] queue = new int[] { -1, -1, -1, -1 };
        //верх
        if (targetCur >= 20)
        {
            queue[forw] = targetCur - 20;
            forw += 1;
        }
        if (targetCur - targetCur / artCanvasScale * artCanvasScale != artCanvasScale - 1)
        {
            queue[forw] = targetCur + 1;
            forw += 1;
        }
        if (targetCur < 20 * (artCanvasScale - 1))
        {
            queue[forw] = targetCur + 20;
            forw += 1;
        }
        if (targetCur - targetCur / 20 * 20 > 0)
        {
            queue[forw] = targetCur - 1;
            forw += 1;
        }
        int ran = Random.Range(0, forw);
        if (targetCur - queue[ran] == 20)
        {
            _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (targetCur - queue[ran] == -1)
        {
            _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (targetCur - queue[ran] == -20)
        {
            _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (targetCur - queue[ran] == 1)
        {
            _allColor5[color5Cur].transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        //задаём позицию
        _allColor5[color5Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
        //задаём размер
        scaleArt.x = 20 / artCanvasScale;
        scaleArt.y = 20 / artCanvasScale;
        _allColor5[color5Cur].transform.localScale = scaleArt;

        //наносим урон
        _allColor5[color5Cur].target = targetCur;
        _allColor5[color5Cur].targetNext = queue[ran];
        _allColor5[color5Cur].count = num - 1;
        
    }
    public void ForColor8(int targetCur, int num)
    {
        for (int i = 0; i < 100; i++)
        {
            if (_allColor8[i] == null)
            {
                _allColor8[i] = Instantiate(_color8Prefab, this.transform);
                color8Cur = i;
                break;
            }
            else
            {
                if (_allColor8[i].isActiveAndEnabled == false)
                {
                    _allColor8[i].gameObject.SetActive(true);
                    color8Cur = i;
                    break;
                }
            }
        }

        //задаём позицию
        _allColor8[color8Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
        //задаём размер
        scaleArt.x = 20 / artCanvasScale;
        scaleArt.y = 20 / artCanvasScale;
        _allColor8[color8Cur].transform.localScale = scaleArt;

        //наносим урон
        _allColor8[color8Cur].target = targetCur;
    }
    public void ForColor9(int targetCur, int num)
    {
        for (int i = 0; i < 50; i++)
        {
            if (_allColor9[i] == null)
            {
                _allColor9[i] = Instantiate(_color9Prefab, this.transform);
                color9Cur = i;
                break;
            }
            else
            {
                if (_allColor9[i].isActiveAndEnabled == false)
                {
                    _allColor9[i].gameObject.SetActive(true);
                    color9Cur = i;
                    break;
                }
            }
        }

        if(num == 3 || num == 1)
        {
            _allColor9[color9Cur].transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            _allColor9[color9Cur].transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //задаём позицию
        _allColor9[color9Cur].transform.localPosition = _allFrameArt[targetCur].transform.localPosition;
        //задаём размер
        scaleArt.x = 20 / artCanvasScale;
        scaleArt.y = 20 / artCanvasScale;
        _allColor9[color9Cur].transform.localScale = scaleArt;

        //наносим урон
        _allColor9[color9Cur].target = targetCur;
        _allColor9[color9Cur].targetNext = targetCur;
        _allColor9[color9Cur].count = num;
    }

}
