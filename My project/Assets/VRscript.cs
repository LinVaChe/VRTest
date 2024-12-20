using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRscript : MonoBehaviour
{

    public int a;
    public int b;
    public int c;
    public Text Mytxt;
    public int g;

    public GameObject Cil;
    public int X;
    public int Y;
    public int Z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mytxt.text = g.ToString();
    }

    public void first()
    {
        g = g + 2;
        X = 2; Z = 2; Y = 1;
        Cil.transform.position = new Vector3(X, Y, Z);
    }

    public void second()
    {
        g--;
        X = 0; Z = 0; Y = 1;
        Cil.transform.position = new Vector3(X, Y, Z);
    }

    public void nul()
    {
        a = Random.Range(0, 255);
        b = Random.Range(0, 255);
        c = Random.Range(0, 255);

        this.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);
    }
}
