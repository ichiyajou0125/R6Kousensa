using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public GameData GM;

    public Time_Data TM;

    public float time;
    float befor_time;

    int time_cal;

    void Start()
    {
        GM.Area_score = 0;
        GM.Enemy_score = 0;
        GM.Time_score = 0;
        GM.Enemy_num = 0;
        GM.Session_num = 0;
        GM.play_score = 0;
        GM.bonus_score = 0;
    }

    void FixedUpdate()
    {
        Timer();
        now_score();
        Load_Scene(TM.now_time);
    }

    void Timer()
    {
        if (GM.Session_num != 0 && GM.Session_num != 2 && GM.Session_num != 4 && GM.Session_num != 6)
        {
            time += Time.deltaTime;
            //Debug.Log(time + "ÅF" + befor_time);
            if (Math.Truncate(time) != Math.Truncate(befor_time))
            {
                TM.now_time += 1;
            }
            befor_time = time;
        }
    }

    void now_score()
    {
        GM.play_score = GM.Enemy_score + GM.Area_score + GM.bonus_score;
    }

    void Load_Scene(int time)
    {
        if(GM.play_count == 11)
        {
            time_cal = time - 300;

            GM.Time_score = 20 * -time_cal;

            GM.play_score = GM.Enemy_score + GM.bonus_score + GM.Area_score + GM.Time_score;
            if (GM.high_score <= GM.play_score)
            {
                GM.high_score = GM.play_score;
            }
            SceneManager.LoadScene("Score_Scene");
        }
    }
}
