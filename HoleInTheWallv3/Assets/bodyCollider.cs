using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyCollider : MonoBehaviour
{
    private bool hasCollided = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision)
    {
        if (!hasCollided && collision.gameObject.tag == "Walls") //if collider hits wall, deduct score once
        {
            Debug.Log("wall hit");
            hasCollided = true;
            GameController.DeductScore(100);
        }
        if(collision.gameObject.tag == "LevelStart")//reset at the start of levels
        {
            
            hasCollided = false;
        }
    }



}
