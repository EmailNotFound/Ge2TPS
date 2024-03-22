using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jieshu : MonoBehaviour
{ public static jieshu instance;
    public GameObject a, b;
    public Text tex;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void Again()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        tex.text = "µÃ·Ö£º" + i;
        if (i > 20)
        {
            a.SetActive(true);
        }
    }
}
