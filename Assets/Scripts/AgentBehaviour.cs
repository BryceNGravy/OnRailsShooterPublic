using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehaviour : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;
    private GameObject seekObject;
    // Start is called before the first frame update
    void Start()
    {
        seekObject = GameObject.FindWithTag("Player");
        if(seekObject == null)
        {
            Debug.Log("Player not found.");
        }
        //needs to be checked for efficiency, especially with lots of these objects in a scene
        InvokeRepeating("SeekTarget", 0, 1);
    }

    private void SeekTarget()
    {
        //In future will better seek the player's plane based on the position they're headed to instead of where they currently are/were
        agent.SetDestination(seekObject.transform.position);
    }
}
