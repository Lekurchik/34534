using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider ether)
    {
      //Увеличение силы прыжка
      ether.GetComponent<Jump>().jumpStrength = 10;


    }
   
    void OnTriggerExit(Collider ether)
    {
       //Уменьшение силы прыжка
       ether.GetComponent<Jump>().jumpStrength = 2;
 
    }
}
