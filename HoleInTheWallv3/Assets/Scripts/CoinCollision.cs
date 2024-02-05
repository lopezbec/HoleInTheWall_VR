using UnityEngine;
using System.Collections;
using System;

public class CoinCollision : MonoBehaviour {
    private double timeCnt = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    void OnTriggerEnter(Collider c) {
		CollectCoin();
    }

    protected void Move()
    {
        transform.Rotate(0, Time.deltaTime * 30, 0);
        transform.Translate(0, (float)Math.Cos(timeCnt / 90) / 900, 0);
        timeCnt++;
    }

    protected void CollectCoin()
    {
        GameController.AddCoin();
        gameObject.SetActive(false);
    }
}
