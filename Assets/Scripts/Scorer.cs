using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int count = 0;
   private void OnCollisionEnter(Collision other) 
   {
       if(other.gameObject.tag != "Hit")
       {
           count++;
           Debug.Log("You've bumped into an obstacle this many times: " + count);
       }
   }
}
