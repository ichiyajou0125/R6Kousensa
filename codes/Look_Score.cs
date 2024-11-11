using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Look_Score : MonoBehaviour
{
    public GameData GM;
    public Time_Data TM;

    public TextMeshProUGUI Enemy_Score;
    public TextMeshProUGUI Area_Score;
    public TextMeshProUGUI Time_Score;
    public TextMeshProUGUI Bonus_Score;
    public TextMeshProUGUI Now_Score;
    public TextMeshProUGUI Hight_Score;
    public TextMeshProUGUI Timer;

    int time;
    int time_min;
    int time_sec;
    string time_min_str = "00";
    string time_sec_str = "00";

    // Start is called before the first frame update
    void Start()
    {
        timer_time(TM.now_time);

        Enemy_Score.text = GM.Enemy_score.ToString();
        Area_Score.text = GM.Area_score.ToString();
        Time_Score.text = GM.Time_score.ToString();
        Bonus_Score.text = GM.bonus_score.ToString();
        Now_Score.text = GM.play_score.ToString();
        Hight_Score.text = GM.high_score.ToString();
        Timer.text = time_min_str + ":" + time_sec_str;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Play_Scene");
        }
    }

    void timer_time(int time)
    {
        time_min = time / 60;
        time_sec = time % 60;
        if (time_min <= 9)
        {
            time_min_str = "0" + time_min.ToString();
        }
        else
        {
            time_min_str = time_min.ToString();
        }
        if (time_sec <= 9)
        {
            time_sec_str = "0" + time_sec.ToString();
        }
        else
        {
            time_sec_str = time_sec.ToString();
        }
    }
}
