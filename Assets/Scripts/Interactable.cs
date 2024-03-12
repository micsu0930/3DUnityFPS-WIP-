using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    
    public void BaseInteract()
    {
        Interact();
        //function will be called from player
    }
    protected virtual void Interact () 
    { 
    
    }
    
}
