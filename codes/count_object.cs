using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_object : MonoBehaviour
{
    public GameData GM;
    public GameObject prefab_bonus_obj;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0, 0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            GM.play_count += 1;
            GM.Session_num += 1;
            Debug.Log(GM.play_count);
            if(GM.Session_num == 1)
            {
                Debug.Log("bonusèoåªÅI");
                Instantiate(prefab_bonus_obj, new Vector3(5, 1, -5), Quaternion.identity);
            }
            else if(GM.Session_num == 3)
            {
                Instantiate(prefab_bonus_obj, new Vector3(8.5f, 1, 6), Quaternion.identity);
                Instantiate(prefab_bonus_obj, new Vector3(-5, 1, -9), Quaternion.identity);
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
