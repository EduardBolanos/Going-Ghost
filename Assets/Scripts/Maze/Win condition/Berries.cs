using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berries : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        transform.parent.SendMessage("OnBerryFound", SendMessageOptions.DontRequireReceiver);
        GameObject.Destroy(gameObject);
    }
}
