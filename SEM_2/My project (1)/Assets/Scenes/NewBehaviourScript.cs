using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void OnMouseDown()
    {
    
        Debug.Log("Тест пройден успешно");
        GetComponent<Renderer>().material.color = Color.green;
    }
}
