using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForcedPerspectiveMovment : MonoBehaviour
{
    private float movmentSpeed = 0.05f;
    private Vector3 startScale = new Vector3(5,5,0);
    private GameObject player;
    private void Awake()
    {
        transform.localScale = new Vector3(0,0,0);
        player = GameObject.Find("Player");
    }
   private void Update()
   {
        MoveToCam();
   } 
   private void MoveToCam()
   {
       transform.localScale = new Vector3(transform.localScale.x + movmentSpeed, transform.localScale.y + movmentSpeed, transform.localScale.z);
       Vector3 tmpPos = transform.position;
       tmpPos.z -= movmentSpeed/4;
       transform.position = tmpPos;   
          
   }
   public bool OnPlayerLevel()
   {
        bool onPlayerLevel;
        if(transform.position.z == player.transform.position.z)
        {
          onPlayerLevel = true;
        }
        else
        {
          onPlayerLevel = false;
        }
        return onPlayerLevel;
   }

   private void OnTriggerStay2D(Collider2D other)
   {
     Debug.LogWarning(other.tag);
     if(other.tag == "Player")
     {
          Debug.LogWarning(other.tag);
     }
   }
   
   public void SetStartScale(Vector3 startingScale)
   {
        startingScale = startScale;
   }
    private void FadeOut()
   {
        if(transform.position.z <= -5)
        {
           Color tmpColor = GetComponent<SpriteRenderer>().color;
           tmpColor.a = tmpColor.a-movmentSpeed/2;
           GetComponent<SpriteRenderer>().color = tmpColor;
        }
   }
}
