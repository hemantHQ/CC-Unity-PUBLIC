using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float move_speed;
    float repeat_width;
  Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
        repeat_width = GetComponent<BoxCollider2D>().size.x / 2;
    }
    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime*move_speed);
        if (transform.position.x < startPos.x - repeat_width)
        {
            transform.position = startPos;
        }
    }

}
