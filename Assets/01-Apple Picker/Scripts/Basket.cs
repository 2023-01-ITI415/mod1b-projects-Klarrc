using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text         scoreGT;

    // Start is called before the first frame update
   void Start() {
        // Find a reference to the ScoreCounter
 
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        // Get the Text Component of that GameO
        scoreGT = scoreGO.GetComponent<Text>();
        // Set the starting number of points to
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
    void OnCollisionEnter( Collision coll ) {  
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if ( collidedWith.tag == "Apple" ) {   
            Destroy( collidedWith );
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
            if (score > HighScore.score) {
                HighScore.score = score;
 
            }
        }
    }
}
