using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WallDestroyer : MonoBehaviour
{
    private void Start()
    {
    }


    void OnTriggerEnter(Collider c)
    {

        GameController.AddCollision();
        transform.GetComponentInParent<Grader>().Fail();


    }
}
 