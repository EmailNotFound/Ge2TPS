using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float chaseRange = 20f;
    public float moveSpeed = 5f;
    public Animator animator;
    public float EnemyHp = 5;
    public Rigidbody rb;
    public float force = 30000f;
    private Collider collider;


    private void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        if (playerGameObject != null)
        {
            player = playerGameObject.transform;
        }
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
    }

    private void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        if (EnemyHp > 0)
        {
            if (distanceToPlayer <= chaseRange)
            {
                ChasePlayer();
                animator.SetBool("IsChasing", true);
            }
            else
            {
                animator.SetBool("IsChasing", false);
            }

            if (distanceToPlayer <= 5f)
            {
                animator.SetBool("IsAttacking", true);
            }
            else
            {
                animator.SetBool("IsAttacking", false);
            }
        }
        else if (EnemyHp <= 0)
        {
            animator.SetTrigger("IsDead");
            DisableCollider();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Gethit();
            EnemyHp--;
        }
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject pler = GameObject.FindGameObjectWithTag("Player");
            pler.GetComponent<Playercontroller>().PlayerHp -= 1f;
        }
    }

    void ChasePlayer()
    {
        Vector3 directionToPlayer = (player.position - transform.position).normalized;
        transform.position += directionToPlayer * moveSpeed * Time.deltaTime;

        transform.LookAt(player);
    }

    void Gethit()
    {
        Vector3 forceDirection = -transform.forward * force;
        rb.AddForce(forceDirection);
    }

    public void DisableCollider()
    {
        if (collider != null)
        {
            collider.enabled = false;
        }
    }
}
