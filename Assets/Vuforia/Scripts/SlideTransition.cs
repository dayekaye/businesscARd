using UnityEngine;
using System.Collections;

public class SlideTransition : MonoBehaviour
{
    void OnAnimatorMove()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            //Debug.Log(transform.position.x);
            if (transform.position.x < .2)
            {
                Vector3 newPosition = transform.position;
                newPosition.x += Time.deltaTime;
                transform.position = newPosition;
            }
            else {
                return;
            }
            
        }
    }
}