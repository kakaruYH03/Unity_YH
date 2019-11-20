using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePos : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float startPos;
    [SerializeField] float lastPos;
    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime,0 ,0);

        if(transform.position.x <= lastPos)
        {
            transform.Translate(-1 * (lastPos - startPos),0 ,0);
            SendMessage("ChangePosition", SendMessageOptions.DontRequireReceiver);
        }
    }
}
