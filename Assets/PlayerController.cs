using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody rb;
    static public float speed = 15;
    public AudioClip clip;
    public GameObject bullet;
    public Transform pos;
    public float PlayerHp = 10;
    public float maxplayerHP = 10;
    public Animator animator;
    bool isProtected;

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
            if (speed >= 2)
            {
                speed -= 0.15f;
            }
        }

        float x, y;
        x = Input.GetAxis("Mouse X") * Time.deltaTime * 200;
        y = Input.GetAxis("Mouse Y") * Time.deltaTime * 200;
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
        vector = transform.position + this.transform.forward * Time.deltaTime * x * speed + transform.right * Time.deltaTime * y * speed;
        rb.MovePosition(vector);
    }

    public void Ondamage(int damage)
    {
        PlayerHp -= damage;
    }

    IEnumerator ProtectCoroutine()
    {
        isProtected = true;
        yield return new WaitForSeconds(0.5f);
        isProtected = false;
    }
}
