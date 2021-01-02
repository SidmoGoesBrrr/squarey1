using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour{
     public PlayerControls controls;
     public GameObject objectToDisable;
     public static bool disabled =false;
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            controls.enabled=false;
            objectToDisable.active = true;
            
        }

                if (collision.gameObject.tag == "Lava")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            controls.enabled=false;
        }
  
        
    }

}
