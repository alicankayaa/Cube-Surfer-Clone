using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{   
    [SerializeField] private GameObject button;
   private void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Cube")){
        Time.timeScale = 0;
        button.SetActive(true);   
    }
   }
}
