using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public GameData GM;
    int now_Session_num;

    public int my_score;

    // Start is called before the first frame update
    void Start()
    {
        now_Session_num = GM.Session_num;
        my_score = 100;
        
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
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == "bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            GM.Enemy_score += my_score;
            GM.Enemy_num -= 1;
        }
    }
}
