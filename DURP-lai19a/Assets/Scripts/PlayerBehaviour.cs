using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        // If the game is paused, don't do anything
        if (PauseScreenBehaviour.paused)
        {
            return;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // If the game is paused, don't do anything
        if (PauseScreenBehaviour.paused)
        {
            return;
        }

    }
}
