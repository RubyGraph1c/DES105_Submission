using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoalArea : MonoBehaviour
{
    public EventTrigger.TriggerEvent goal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallController ball = collision.gameObject.GetComponent<BallController>(); //When ball collides with goal area

        if (ball != null) //checks that ball is object that has been collided with
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current); //an event happens - someone has scored
            this.goal.Invoke(eventData);
        }
    }
}
