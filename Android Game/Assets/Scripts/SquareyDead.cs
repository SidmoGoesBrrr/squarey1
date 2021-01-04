using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    


public class SquareyDead : MonoBehaviour{

        public PlayerControls controls;
        //makes a reference to the playercontorls function which we can enable or disable
        public GameObject DieText;  
        public GameObject LavaText;

        //adds reference to the gameobject which we can activate
        public GameObject RestartButton;
        public GameObject MenuButton;
        public GameObject StarEyes1;
        public GameObject StarEyes2;
        public GameObject Eyes;
        public GameObject Fireeye1;
        public GameObject Fireeye2;
        public Camera cam;

        public static bool enabled =false;
               private void OnCollisionEnter2D(Collision2D collision)//function for collision
                {
                
                   if (collision.gameObject.tag == "Obstacle")//tags are given in the inpsctor, next to layer
                {
                  controls.enabled=false;
                  DieText.active = true;
                  RestartButton.active = true;
                  MenuButton.active = true;
                  StarEyes1.active = true;
                  StarEyes2.active = true;
                  Eyes.active = false;

                }
                   if (collision.gameObject.tag == "Lava")
        {
            controls.enabled=false;
             Fireeye1.active = true;
             Fireeye2.active = true;
             Eyes.active = false;
             cam.orthographicSize = 3.0f;
             RestartButton.active = true;
             MenuButton.active = true;       
             LavaText.active = true;     
        }//disables controls in Lava
                }  
                        }