using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Repop : MonoBehaviour
{
    public GameData GM;

    float pop_position_x;
    float pop_position_y;
    float pop_position_z;
    Vector3 pop_postion;

    float repopSpan;
    float timeElapsed;

    public GameObject prefab_Enemy_1;
    public GameObject prefab_Enemy_2;
    public GameObject prefab_Enemy_3;

    int Enemy_Random;

    // Start is called before the first frame update
    void Start()
    {
        timeElapsed = 0;
        init_repopspan();
        Reset_PopPsition();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(GM.play_count);
        if (GM.Session_num != 0 && GM.Session_num != 2 && GM.Session_num != 4 && GM.Session_num != 6)
        {
            Debug.Log("Session_num = " + GM.Session_num);
            repop();
        }
    }

    void repop()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= repopSpan)
        {
            UnityEngine.Random.InitState(DateTime.Now.Millisecond);
            Enemy_Random = UnityEngine.Random.Range(1, 4);
            if (Enemy_Random == 1)
            {
                Instantiate(prefab_Enemy_1, pop_postion, Quaternion.identity);
                init_repopspan();
                Reset_PopPsition();
                timeElapsed = 0;
            }
            else if(Enemy_Random == 2)
            {
                Instantiate(prefab_Enemy_2, pop_postion, Quaternion.identity);
                init_repopspan();
                Reset_PopPsition();
                timeElapsed = 0;
            }
            else if (Enemy_Random == 3)
            {
                Instantiate(prefab_Enemy_3, pop_postion, Quaternion.identity);
                init_repopspan();
                Reset_PopPsition();
                timeElapsed = 0;
            }
            GM.Enemy_num += 1;
        }
    }

    void init_repopspan()
    {
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
        repopSpan = UnityEngine.Random.Range(10f, 15f);
        Debug.Log(repopSpan);
    }

    void Reset_PopPsition()
    {
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
        pop_position_x = UnityEngine.Random.Range(19.5f, -19.5f);
        pop_position_y = UnityEngine.Random.Range(4f, 10f);
        pop_position_z = UnityEngine.Random.Range(14.5f, -9.5f);

        pop_postion = new Vector3(pop_position_x, pop_position_y, pop_position_z);
    }
}