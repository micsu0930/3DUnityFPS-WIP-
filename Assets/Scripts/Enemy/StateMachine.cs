using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState; //prtoperty for patrol state
    public PatrolState patrolState;

    public void Initialise () 
    { 
        //setup default state
        patrolState = new PatrolState();
        ChangeState(patrolState);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeState != null)
        {
            activeState.Perform();
        }
    }

    public void ChangeState(BaseState newState)
    {
        if (activeState != null)
        {
            //run cleanup on state
            activeState.Exit();
        }
        //change into new state
        activeState = newState;
        if (activeState != null)
        {
            //setup new state
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();  
            //assigne state
            activeState.Enter();
        }
    }
}
