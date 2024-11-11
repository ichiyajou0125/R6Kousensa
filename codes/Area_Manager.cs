using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_Manager : MonoBehaviour
{
    public GameData GM;

    public GameObject Start_Wall_1;
    public GameObject Start_Wall_2;

    public GameObject Rood_1;
    public GameObject Rood_2_1;
    public GameObject Rood_2_2;
    public GameObject Rood_2_3;
    public GameObject Rood_3_1;
    public GameObject Rood_3_2;
    public GameObject Rood_3_3;
    public GameObject Rood_3_4;

    public GameObject Area_obj;

    // Start is called before the first frame update
    void Start()
    {
        GM.play_count = 0;
        GM.Session_num = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Area_Management();
    }

    void Area_Management()
    {
        if (GM.play_count == 0)
        {
            Start_Wall_1.SetActive(true);
            Start_Wall_2.SetActive(true);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Area_obj.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
        }
        else if (GM.play_count == 1)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(true);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 2)
        {
            Start_Wall_1.SetActive(true);
            Start_Wall_2.SetActive(true);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(false);
        }
        else if (GM.play_count == 3)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(true);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 4)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(true);
            Rood_2_2.SetActive(true);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 5)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(true);
            Rood_2_2.SetActive(true);
            Rood_2_3.SetActive(true);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 6)
        {
            Start_Wall_1.SetActive(true);
            Start_Wall_2.SetActive(true);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(false);
        }
        else if (GM.play_count == 7)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(true);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 8)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(true);
            Rood_3_2.SetActive(true);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 9)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(true);
            Rood_3_2.SetActive(true);
            Rood_3_3.SetActive(true);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 10)
        {
            Start_Wall_1.SetActive(false);
            Start_Wall_2.SetActive(false);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(true);
            Rood_3_2.SetActive(true);
            Rood_3_3.SetActive(true);
            Rood_3_4.SetActive(true);
            Area_obj.SetActive(true);
        }
        else if (GM.play_count == 10)
        {
            Start_Wall_1.SetActive(true);
            Start_Wall_2.SetActive(true);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(false);
        }
        else if (GM.play_count == 11)
        {
            Start_Wall_1.SetActive(true);
            Start_Wall_2.SetActive(true);
            Rood_1.SetActive(false);
            Rood_2_1.SetActive(false);
            Rood_2_2.SetActive(false);
            Rood_2_3.SetActive(false);
            Rood_3_1.SetActive(false);
            Rood_3_2.SetActive(false);
            Rood_3_3.SetActive(false);
            Rood_3_4.SetActive(false);
            Area_obj.SetActive(false);
        }
    }

}
