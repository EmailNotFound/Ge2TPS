using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionController : MonoBehaviour
{
    public float moveSpeed = 20f;
    public int keyCollected = 0;
    public GameObject Cube;
    public float MoveDistance = 20f;

    private void Update()
    {
        
    }

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            keyCollected += 1;
            if(keyCollected == 2)
            {
                MoveCube();
            }
        }
    }
    void MoveCube()
    {
        if (Cube != null)
        {
            Cube.transform.position += new Vector3(0, MoveDistance, 0);
        }
    }
}
