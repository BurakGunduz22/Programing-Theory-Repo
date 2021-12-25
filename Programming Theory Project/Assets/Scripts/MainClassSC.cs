using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClassSC : MonoBehaviour
{
    protected virtual void DestroyPlayerObject(){
        Destroy(gameObject);
    }
    protected virtual void JumpAction(){
        transform.Translate(Vector3.up*Time.deltaTime);
    }
}
