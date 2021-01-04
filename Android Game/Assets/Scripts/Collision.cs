using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour{
     public PlayerControls controls;
     public GameObject objectToDisable;
     public static bool disabled =false;
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            controls.enabled=false;
            objectToDisable.active = true;
            
        }

                if (collision.gameObject.tag == "Lava")
        {
            controls.enabled=false;
        }//disables controls in Lava
  
        
    }

}
