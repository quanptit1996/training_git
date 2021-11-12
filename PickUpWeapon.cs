using System.Collections;
using System.Collections.Generic;
using Scrips;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWeapon : MonoBehaviour
{
    public float theDistance;

    public GameObject fakeWeapon;
    public GameObject realWaepon;
    public AudioSource soundPickUp;
  
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }
    
    
    private void OnMouseOver()
    {
      

        if (Input.GetButtonDown("Pickup"))
        {
            this.GetComponent<BoxCollider>().enabled = false;//box bao quanh cửa để cho raycast nhận diện
           
            fakeWeapon.SetActive(false);
            realWaepon.SetActive(true);
            soundPickUp.Play();
         
        }
    }

 
}

