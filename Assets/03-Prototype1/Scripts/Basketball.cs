using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    public static float bottomY = -8.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < bottomY ) 
        { 
            Destroy( this.gameObject );
        }
    }
}
