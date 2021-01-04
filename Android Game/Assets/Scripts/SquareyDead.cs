using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    


public class SquareyDead : MonoBehaviour{

        public PlayerControls controls;
        //makes a reference to the playercontorls function which we can enable or disable
        public GameObject DieText;
        //adds reference to the gameobject which we can activate
        public GameObject RestartButton;
        public GameObject MenuButton;
        public GameObject StarEyes1;
        public GameObject StarEyes2;
        public GameObject Eyes;

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
                }  
                        }