using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject Player;
    public Camera Scope_camera;

    public GameObject prefab_bullet;

    GameObject Bullet;

    private float Bullet_speed = 50.0f;
    private float DestroyTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    void shoot()
    {
        Vector3 shoot_pos = Scope_camera.transform.position;

        if (Scope_camera.gameObject.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Bullet = Instantiate(prefab_bullet, shoot_pos, Quaternion.identity);
                Bullet.GetComponent<Rigidbody>().velocity += Scope_camera.transform.forward * Bullet_speed;
            }
        }
        Destroy(Bullet, DestroyTime);
    }
}
