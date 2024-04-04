using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringController : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * 50);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
        else if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
