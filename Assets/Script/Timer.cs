using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text time_text;
    public Text time_text_1;
    public Text time_text_2;
    public GameObject TimesUp;


    //設定計時器的時，分，秒
    int second = 0;
    int minute = 0;
    int hour = 0;
    //設定需要顯示到屏幕上的時間
    string s;
    string m;
    string h;
    //用來計算時間
    float time;
    string timeStr = "0:0:0";

    public bool is_timer=true;

    //Update是每幀執行一次，1秒回執行多次
    void Update()
    {
        if (is_timer)
        {
            //Time.deltaTime是執行一幀需要的時間
            time += Time.deltaTime;

            if (time >= 1)
            {
                //當time>=1時，表示Update執行總時間到了1秒
                second++;
                //這時需要time去重新記錄Update執行的時間，要減去1(有可能會大於1)
                time -= 1;
            }
            if (second == 60)
            {
                //秒和分鐘的關系
                minute++;
                second = 0;
            }
            if (minute == 60)
            {
                //分鐘和小時的關系
                hour++;
                minute = 0;
            }
        }
        {
            //時間限制(可根據對象需要改)
            if (minute == 10)
            { Suddentstop();}
        }
    }

    //時間限制(可根據對象需要改)
    void Suddentstop()
    {
        TimesUp.SetActive(true);
        NavMeshPoint.is_Navigation = false;
        is_timer = false;
    }


    //顯示在界面的數據
    void OnGUI()
    {

        s = "" + second;
        m = "" + minute;
        h = "" + hour;
        timeStr = h + ":" + m + ":" + s;
        time_text.text = timeStr;
        time_text_1.text = timeStr;
        time_text_2.text = timeStr;
        //在屏幕上顯示的位置和內容
        // GUI.Label(new Rect(0, 60, 100, 60), timeStr);
    }
}
