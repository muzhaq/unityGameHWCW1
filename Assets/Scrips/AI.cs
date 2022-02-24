using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AI : MonoBehaviour
{
    // NavMeshAgen is a unity's default AI component used to identify/ controll an AI npc/ object
    public NavMeshAgent Nav;
    // Position of the target (in this case our player)
    public Transform Target;
    // Reference to the GameOver panel
    public GameObject gameover;
    void Start()
    {
        // finding the player with it's tag "Player" and getting it's transform component
        Target = GameObject.FindGameObjectWithTag( "Player" ).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // checks if the target is not null, which means we have found the player then it will follow it
        if (Target != null)
        {
            // setting the current enemy's destination to the player's position
            Nav.SetDestination( Target.position );
            // setting the enemy to look at the player
            transform.LookAt( Target.position );
        }
            
            
    }
    // checking if the enemy is colliding with anything
    private void OnCollisionEnter( Collision collision )
    {
        // cecking if it is colliding with player then setting the GameOver screen/ panel to activate
        if (collision.transform.tag == "Player")
        {
            // activating GameOver
            gameover.SetActive( true );
        }
    }
}
