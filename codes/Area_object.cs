using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_object : MonoBehaviour
{
    public GameData GM;

    public GameObject prefab_count_obj;
    public GameObject prefab_bonus_obj;

    int count;

    private void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0, 0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (GM.play_count == 1)
            {
                Instantiate(prefab_count_obj, new Vector3(3, 4.5f, 16.5f), Quaternion.identity);
                GM.play_count += 1;
                GM.Session_num += 1;
                this.transform.position = new Vector3(11.5f, 1.5f, -9f);
            }
            else if (GM.play_count == 3)
            {
                Debug.Log(count);
                if (count == 0)
                {
                    this.transform.position = new Vector3(-5.5f, 1.5f, -15);
                }
                else if (count == 1)
                {
                    this.transform.position = new Vector3(8, 1.5f, 11.75f);
                }
                else if (count == 2)
                {
                    this.transform.position = new Vector3(1.7f, 1.5f, 1.4f);
                    GM.play_count += 1;
                }
                Debug.Log(this.transform.position);
                count += 1;
            }
            else if(GM.play_count == 4)
            {
                count = 0;
                this.transform.position = new Vector3(3, 1.5f, -23);
                GM.play_count += 1;
            }
            else if (GM.play_count == 5)
            {
                Instantiate(prefab_count_obj, new Vector3(3, 4.5f, -16.5f), Quaternion.identity);
                GM.play_count += 1;
                GM.Session_num += 1;
                this.transform.position = new Vector3(12.5f, 1.5f, -12.1f);
            }
            else if(GM.play_count == 7)
            {
                this.transform.position = new Vector3(-2f, 1.5f, 1.75f);
                GM.play_count += 1;
            }
            else if(GM.play_count == 8)
            {
                this.transform.position = new Vector3(-5.75f, 1.5f, 13.25f);
                GM.play_count += 1;
                Instantiate(prefab_bonus_obj, new Vector3(9.5f, 1, -4), Quaternion.identity);
                Instantiate(prefab_bonus_obj, new Vector3(-3.2f, 1, 7), Quaternion.identity);
            }
            else if(GM.play_count == 9)
            {
                this.transform.position = new Vector3(3, 1.5f, 23);
                GM.play_count += 1;
            }
            else if (GM.play_count == 10)
            {
                GM.play_count += 1;
                GM.Session_num += 1;
            }
            Debug.Log(GM.play_count);
        }
    }
}
