using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    public float        speed = 1f;
    public float        upAndDownEdge = 6.7f;
    public float chanceToChangeDirections;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
        if ( pos.y < -upAndDownEdge ) {
            speed = Mathf.Abs(speed);
        } else if ( pos.y > upAndDownEdge ) {
            speed = -Mathf.Abs(speed);
        } else if (Random.value < chanceToChangeDirections ) {
            speed *= -1;
        }
    }
}
