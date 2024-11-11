using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Canvas_Manager : MonoBehaviour
{
    public GameData GM;
    public Time_Data TM;

    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Score; 

    int time;
    int time_min;
    int time_sec;
    string time_min_str = "00";
    string time_sec_str = "00";

    string score_str;

    public Camera Main_camera;
    public Camera Scope_camera;

    public Canvas canvas;

    bool[] jage = new bool[5];

    // Start is called before the first frame update
    void Start()
    {
        TM.now_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Is_Canvas_display();
        time = TM.now_time;
        timer_time(time);
        Timer.text = time_min_str + ":" + time_sec_str;

        str_score();
        Score.text = score_str;
    }

    void Is_Canvas_display()
    {
        int count = 0;
        if (Main_camera.gameObject.activeSelf)
        {
            jage[0] = true;
            jage[1] = false;
            jage[2] = true;
            jage[3] = false;
            jage[4] = true;            
        }
        else if (Scope_camera.gameObject.activeSelf)
        {
            jage[0] = false;
            jage[1] = true;
            jage[2] = true;
            jage[3] = false;
            jage[4] = true;
        }

        if (GM.Enemy_num != 0)
        {
            jage[3] = true;
        }
        foreach(Transform child in canvas.transform)
        {
            child.gameObject.SetActive(jage[count]);
            count++;
        }
    }

    void timer_time(int time)
    {
        time_min = time / 60;
        time_sec = time % 60;
        if(time_min <= 9)
        {
            time_min_str = "0" + time_min.ToString();
        }
        else
        {
            time_min_str = time_min.ToString();
        }
        if(time_sec <= 9)
        {
            time_sec_str = "0" + time_sec.ToString();
        }
        else
        {
            time_sec_str = time_sec.ToString();
        }
    }

    void str_score()
    {
        score_str = GM.play_score.ToString();
    }
}
