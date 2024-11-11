using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_rotation : MonoBehaviour
{
    public GameObject Player;

    float mouse_rotateX;
    float mouse_rotateY;

    float rota_speed = 2.0f;

    // Start is called before the first frame update
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        rotation();
    }

    void rotation()
    {
        mouse_rotateX = Input.GetAxis("Mouse Y");
        mouse_rotateY = Input.GetAxis("Mouse X");

        mouse_rotateX *= 1f;
        mouse_rotateY *= 1f;

        this.transform.RotateAround(Player.transform.position, Vector3.up, -mouse_rotateY);
        this.transform.RotateAround(Player.transform.position, transform.right, mouse_rotateX);
    }


}
