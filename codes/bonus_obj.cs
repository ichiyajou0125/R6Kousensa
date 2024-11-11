using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus_obj : MonoBehaviour
{
    public GameData GM;
    int now_session;

    // Start is called before the first frame update
    void Start()
    {
        now_session = GM.Session_num;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0.2f, 0.7f, 0.1f);
        if(now_session != GM.Session_num)
        {
            Destroy(this.gameObject);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GM.bonus_score += 500;
            Destroy(this.gameObject);
        }
    }
}
