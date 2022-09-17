using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleWall : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.CompareTag("Enemy") || other.CompareTag("Player")){
           Destroy(other.gameObject);
       }
   }
}
                        