using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HoopGoal : MonoBehaviour
{
    public TextMeshProUGUI countText;
	public GameObject winTextObject;
	static public bool 	goalMet = false;
    private int count;

	void OnTriggerEnter(Collider other) {
		// when the trigger is hit by something
		// check to see if it's a Projectile 
		if (other.gameObject.tag == "Projectile") {
			// if so, set goalMet = true
			HoopGoal.goalMet = true;

            count = count + 1;

            SetCountText ();

			
            
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        winTextObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (HoopGoal.goalMet == true)
        {


        }
    }
    void SetCountText(){
        countText.text = "Baskets: " + count.ToString();
        if (count >= 12) 
		{
             // Set the text value of your 'winText'
            winTextObject.SetActive(true);
		}
    }
}
