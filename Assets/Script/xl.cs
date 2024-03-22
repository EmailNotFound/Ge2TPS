using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class xl : MonoBehaviour
{ public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<NavMeshAgent>().destination = pos.position;
    }
}
