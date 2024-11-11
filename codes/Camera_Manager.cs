using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Manager : MonoBehaviour
{
    public Camera Main_camera;
    public Camera Scope_camera;
    public GameObject Player;

    Vector3 init_distans;
    Vector3 init_rotetion;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 Player_position = Player.transform.position;

        Scope_camera.transform.position = new Vector3(Player_position.x, Player_position.y + 0.3f, Player_position.z);
        Scope_camera.gameObject.SetActive(false);

        init_transform();
    }

    // Update is called once per frame
    void Update()
    {
        Scope();
    }

    void Scope()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Main_camera.gameObject.SetActive(!Main_camera.gameObject.activeSelf);
            Scope_camera.gameObject.SetActive(!Scope_camera.gameObject.activeSelf);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            Main_camera.gameObject.SetActive(!Main_camera.gameObject.activeSelf);
            Scope_camera.gameObject.SetActive(!Scope_camera.gameObject.activeSelf);
        }
    }

    private void init_transform()
    {
        init_distans = new Vector3(-0.1f, 1.25f, -2.25f);
        init_rotetion = new Vector3(20, 0, 0);

        Main_camera.transform.position += init_distans;
        Main_camera.transform.eulerAngles = init_rotetion;
    }
}
