using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : MonoBehaviour
{

    public int a, b, d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void ClickBut1()
    {
        a = Random.Range(0, 255);
        b = Random.Range(0, 255);
        d = Random.Range(0, 255);

        this.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)d, 1);

        for (int i = 0; i < 9; i++)
        {
            Debug.Log(i);
        }
    }
}
