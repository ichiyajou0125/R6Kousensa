using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public GameData GM;

    public Camera Player_main_camera;
    public Camera Player_scope_cammera;

    public static int bullet_count = 0;

    Camera main_camera;

    private float speed;

    float inputHorizontal;
    float inputVertical;

    float repeatSpan;
    float timeElapsed;

    int pull_num;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();

        repeatSpan = 1.0f;
        timeElapsed = 0;
        pull_num = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        now_MainCamera();
        move(main_camera);
        score_pull();
        //Debug.Log(GM.Area_score);
    }

    private void move(Camera main_camera)
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5.0f;
        }
        else
        {
            speed = 3.0f;
        }

        rb.velocity = new Vector3(inputHorizontal, 0, inputVertical).normalized; // ³‹K‰»
        rb.velocity = (main_camera.transform.forward * inputVertical + main_camera.transform.right * inputHorizontal) * speed;

        if(this.gameObject.transform.position.y >= 1.4f)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 1.4f, this.gameObject.transform.position.z);
        }
    }

    void now_MainCamera()
    {
        if (!Player_main_camera.gameObject.activeSelf)
        {
            main_camera = Player_scope_cammera;
        }
        else if (Player_main_camera.gameObject.activeSelf)
        {
            main_camera = Player_main_camera;
        }
    }

    void score_pull()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= repeatSpan)
        {
            GM.Area_score -= pull_num;
            timeElapsed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "area_2")
        {
            GM.Area_score -= 100;
            pull_num = 10;
            timeElapsed = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "area_2")
        {
            pull_num = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy_Attack")
        {
            GM.Enemy_score -= 100;
            Destroy(other.gameObject);
        }
    }
}
