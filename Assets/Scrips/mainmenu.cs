using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    // play the game, it will load the first level
    public void playGame()
    {
        SceneManager.LoadScene( 1 );
    }
    // this function can be called whenever we need to restart the game/ level
    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene( 1 );
        
    }
}
