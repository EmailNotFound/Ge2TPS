using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xietiao : MonoBehaviour
{
    public float i = 2;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "zd")
        {
            img.fillAmount -= 0.5f;
            i--;
        }
    }
    // Update is called once per frame
    void Update()
    {   
        if (i <= 0)
        {
            //jieshu.instance.i++;
            Destroy(this.gameObject);

        }

    }
}
