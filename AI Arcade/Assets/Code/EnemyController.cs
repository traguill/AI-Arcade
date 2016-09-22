using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour 
{
    NavMeshAgent agent;

    public GameObject player;
    PlayerController player_controller;
    public float escape_dst = 5.0f;

    bool follow = true;
    
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        player_controller = player.GetComponent<PlayerController>();
    }

    
	
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyUp(KeyCode.Space))
        {
            follow = !follow;
            if (follow == false)
            {
                agent.speed = 5.0f;
                agent.updatePosition = false;
            }
                
            else
            {
                agent.speed = 3.5f;
                agent.Warp(transform.position);
                agent.updatePosition = true;
            }
                
        }

        if(follow)
        {
            agent.SetDestination(player.transform.position);
        }
        else
        {
            Vector3 distance = transform.position - player.transform.position;
            distance.y = 0;
            if(distance.magnitude < escape_dst)
            {
                transform.position += (distance.normalized * agent.speed) * Time.deltaTime;
            }
        }

            

     
	}
}
