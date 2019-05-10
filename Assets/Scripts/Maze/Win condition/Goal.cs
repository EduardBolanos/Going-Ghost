using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sprite laprasMadSprite;
    public Sprite laprasHappySprite;

    private void Start()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = laprasMadSprite;
    }
    public void OpenGoal()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = laprasHappySprite;
    }

    private void OnTriggerEnter2D()
    {
        transform.parent.SendMessage("OnGoalReached", SendMessageOptions.DontRequireReceiver);
    }
}
