using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Movement Speed //
  public float movedSpeed = 10.0f;
    // Refrence to Player's rigidbody //
  public Rigidbody rb;
    // Jump force //
  public float jumpAmount = 5;
    // Speed of turning/ rotation //
  public float rotationSpeed=90;

    // Function which calls on each frame //
  void Update()
  {
        // Movement function //
    MovePlayer();

  }

  void MovePlayer()
  {
    // if player presses D it will rotate to right
    if (Input.GetKey(KeyCode.D))
    {
            // transform  = player's transform component
            // rotatearound is a unity's default rotation function
            // transform.position = player's current position
            // Vector3.up = y axis
            // it will rotate the player in y axis from its current position with rotaion speed
            transform.RotateAround( transform.position, Vector3.up, rotationSpeed * Time.deltaTime );
    }
        // if player presses A it will rotate to left
    else if (Input.GetKey(KeyCode.A))
    {
            transform.RotateAround( transform.position, -Vector3.up, rotationSpeed * Time.deltaTime );
    }
    // if player presses S it will move backwards
    else if (Input.GetKey(KeyCode.S))
    {
      transform.Translate(0, 0, -1 * Time.deltaTime * movedSpeed);
    }
    // if player presses W it will move forward
    else if (Input.GetKey(KeyCode.W))
    {
      transform.Translate(0, 0, 1 * Time.deltaTime * movedSpeed);
    }
    // if player presses spacebar the player will jump
    if (Input.GetKeyDown(KeyCode.Space))
    {
      rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
    }
  }

}
