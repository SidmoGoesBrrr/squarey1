using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    


public class SquareyDead : MonoBehaviour{

        public PlayerControls controls;
        public GameObject objectToenable1;
        public GameObject objectToenable2;
        public GameObject objectToenable3;
        public static bool enabled =false;
        void OnCollisionEnter2D(Collision2D collision)
        {
         if (collision.gameObject.tag == "Obstacle")
         {
                //If the GameObject has the same tag as specified, output this message in the console
                  controls.enabled=false;
                   objectToenable1.active = true;
                    objectToenable2.active = true;
                     objectToenable3.active = true;

                     }
             }
                }