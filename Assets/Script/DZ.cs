using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ : MonoBehaviour
{
    public GameObject sss;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);

        }
    }
}
