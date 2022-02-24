using UnityEngine;

public class Oscillator : MonoBehaviour
{
  Vector3 startingPosition;
  [SerializeField] Vector3 movementVector;
  [SerializeField] float movementFactor;
  [SerializeField] float period = 2f;
  void Start()
  {
    startingPosition = transform.position;

  }
  void Update()
  {
    if (period <= Mathf.Epsilon)
    {
      return;
    }
    float cycles = Time.time / period; ////Continously Growing over time
    const float tau = Mathf.PI * 2;
    float rawSinWave = Mathf.Sin(cycles * tau);  //going from +1  to -1
    movementFactor = (rawSinWave + 1f) / 2f; //recalculate to go from 0 to 1, its a cleaner
    Vector3 offset = movementVector * movementFactor;
    transform.position = startingPosition + offset;
  }
}
