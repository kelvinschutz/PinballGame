using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropper : MonoBehaviour
{
    public Transform ballPrefab;
    public Transform ballPlaceholder;
    public Counter ballCounter;
    private int count;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DropBall(string theme)
    {
        var ball = Instantiate(ballPrefab, ballPlaceholder.position, Quaternion.identity);
        ball.GetComponent<Ball>().Theme = theme;
        ball.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,3));
        ballCounter.AddBallToGroup(ball.gameObject);
        count++;
    }
}
