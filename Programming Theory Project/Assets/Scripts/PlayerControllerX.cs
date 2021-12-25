using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MainClassSC
{
   protected override void DestroyPlayerObject(){
     Destroy(gameObject.GetComponent<CharacterController>());  
    }// POLYMORPHISM
    private float charValue = 0.5f;
    public float charValue2 // ENCAPSULATION
    {
        get { return charValue; }
        set { charValue = value; } 
    }
    private void Update() {
    if(Input.GetKeyDown(KeyCode.Space)){
        JumpAction();// INHERITANCE
    }
    if(Input.GetKeyDown(KeyCode.Escape)){
        DestroyPlayerObject();// ABSTRACTION
    }
    }
}
