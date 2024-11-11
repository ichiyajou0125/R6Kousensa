using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy_3 : MonoBehaviour
{
    public GameData GM;
    GameObject Player;

    int now_Session_num;

    public int my_score;

    public GameObject prefab_EnemyBullet;
    GameObject Enemy_bullet;

    float bulletSpan;
    float timeElapsed;

    float bulletSpeed;
    float DestroyTime;
    // Start is called before the first frame update
    void Start()
    {
        now_Session_num = GM.Session_num;
        my_score = 400;
        Player = GameObject.Find("Player");

        timeElapsed = 0;
        bulletSpan = 8;
        bulletSpeed = 15f;
        DestroyTime = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.Session_num == 0 && GM.Session_num == 2 && GM.Session_num == 4 && GM.Session_num == 6)
        {
            Destroy(this.gameObject);
        }

        this.gameObject.transform.LookAt(Player.transform.position);
        
        if (now_Session_num != GM.Session_num)
        {
            Destroy(this.gameObject);
            GM.Enemy_num -= 1;
        }

        Enemy_shoot();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            GM.Enemy_score += my_score;
            GM.Enemy_num -= 1;
        }
    }

    void Enemy_shoot()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= bulletSpan)
        {
            Debug.Log("shoot");
            Enemy_bullet = Instantiate(prefab_EnemyBullet, this.gameObject.transform.position, Quaternion.identity);
            Enemy_bullet.transform.LookAt(Player.transform.position);
            Enemy_bullet.GetComponent<Rigidbody>().velocity += Enemy_bullet.transform.forward * bulletSpeed;
            //Enemy_bullet.transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, bulletSpeed);
            timeElapsed = 0;
        }
        Destroy(Enemy_bullet, DestroyTime);
    }
}
