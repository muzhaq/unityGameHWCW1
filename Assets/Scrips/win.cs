using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    // tick if there's another level
    public bool next;
    // Refrence to the win panel
    public GameObject winPanel;
    // checking if someone has entered the green zone
    private void OnCollisionEnter( Collision collision )
    {
        // checking if the intruder is player and if there's another level ahead
        if (collision.transform.tag == "Player" && next)
        {
            // playing the next level
            SceneManager.LoadScene( 2 );
            
        }
        // checking if the intruder is player
        else if (collision.transform.tag == "Player")
        {
            // stopping the game and setting the win panel to activate
            Time.timeScale = 0;
            winPanel.SetActive( true );
        }
    }
}
