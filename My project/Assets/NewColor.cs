using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewColor : MonoBehaviour
{
    public int y;
    public int z;
    public int c;
    static public GameObject first;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void ClickBut()
    {
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);

        this.GetComponent<Renderer>().material.color = new Color32((byte)y, (byte)z, (byte)c, 1);

        for (int i = 0; i < 9; i++)
        {
            Debug.Log(i);
        }
    }

    public void OnTriggerStay(Collider Other)
    {
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);

        this.GetComponent<Renderer>().material.color = new Color32((byte)y, (byte)z, (byte)c, 1);
        Other.GetComponent<Renderer>().material.color= new Color32(122, 12, 18, 1);

    }
}
