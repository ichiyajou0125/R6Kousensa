using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy_2 : MonoBehaviour
{
    public GameData GM;
    int now_Session_num;

    public int my_score;

    int count;

    Vector3 pop_postion;

    float pop_position_x;
    float pop_position_y;
    float pop_position_z;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        now_Session_num = GM.Session_num;
        my_score = 250;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GM.Session_num == 0 && GM.Session_num == 2 && GM.Session_num == 4 && GM.Session_num == 6)
        {
            Destroy(this.gameObject);
        }

        if (now_Session_num != GM.Session_num)
        {
            Destroy(this.gameObject);
            GM.Enemy_num -= 1;
        }

        this.gameObject.transform.Rotate(0.1f, 0.5f, 0.3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "bullet")
        {
            if (count != 2)
            {
                count++;
                UnityEngine.Random.InitState(DateTime.Now.Millisecond);
                pop_position_x = UnityEngine.Random.Range(19.5f, -19.5f);
                pop_position_y = UnityEngine.Random.Range(4f, 10f);
                pop_position_z = UnityEngine.Random.Range(14.5f, -9.5f);

                pop_postion = new Vector3(pop_position_x, pop_position_y, pop_position_z);
                this.gameObject.transform.position = pop_postion;
                Debug.Log(count);
            }
            else
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                GM.Enemy_score += my_score;
                Debug.Log("Destroy");
                GM.Enemy_num -= 1;
            }
        }
    }
}
