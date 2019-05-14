using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sprite laprasMad;
    public Sprite laprasHappy;

    void Start()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = laprasMad;
    }

    public void OpenGoal()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = laprasHappy;
    }

    private void OnTriggerEnter2D()
    {
        transform.parent.SendMessage("OnGoalReached", SendMessageOptions.DontRequireReceiver);
        GameObject.Destroy(gameObject);
        
    }


}
