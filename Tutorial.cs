using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorial;

    void Start()
 {
     tutorial.text = "Aiuta il parco raccogliendo i rifiuti! \r\n\n WASD per muoverti \r\n\n Clic sinistro per prendere/lasciare l'oggetto \r\n\n Clic destro per lanciarlo";
     Time.timeScale = 0;
 }
 
 void Update () 
 {
     if(Input.anyKeyDown)
     {
         Time.timeScale = 1;
         Destroy(gameObject);
     }
 }
}