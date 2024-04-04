using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 15;
    public Animator animator;
    public AudioClip clip;
    public GameObject bullet;
    public Transform pos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    float timer = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("IsRun", true);
        }
        else
        {
            animator.SetBool("IsRun", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            animator.Play("demo_combat_shoot");
            this.GetComponent<AudioSource>().PlayOneShot(clip);
        }

        float x, y;
        x = Input.GetAxis("Mouse X") * Time.deltaTime * 50;
        y = Input.GetAxis("Mouse Y") * Time.deltaTime * 50;
        transform.Rotate(0, x, 0);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, pos.transform.position, pos.transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw("Horizontal");
        float x = Input.GetAxisRaw("Vertical");
        PlayerMoveEvent(x, y);
    }

    void PlayerMoveEvent(float x, float y)
    {
        Vector3 vector = new Vector3(x, 0, -y);
        vector = transform.position + this.transform.forward * Time.deltaTime * x * 20 + transform.right * Time.deltaTime * y * 20;
        rb.MovePosition(vector);
    }
}
