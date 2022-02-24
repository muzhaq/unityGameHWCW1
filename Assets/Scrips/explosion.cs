using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject explosionPrefab,panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter( Collision collision )
    {
        if (collision.transform.tag == "Player")
        {
            explosionPrefab.SetActive( true );
            panel.SetActive( true );
       
        }
    }
}
