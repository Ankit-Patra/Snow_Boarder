using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Ground")
       {
            Debug.Log("You Died!");
       }
    }
}
