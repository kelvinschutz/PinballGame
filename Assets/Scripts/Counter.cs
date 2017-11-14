using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Counter : MonoBehaviour
{
    private List<GameObject> pinballs = new List<GameObject>();
    private BoxCollider collider;
    public Text text;

    void Awake()
    {
        collider = this.GetComponent<BoxCollider>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddBallToGroup(GameObject ball)
    {
        pinballs.Add(ball);
    }

    void OnTriggerExit(Collider other)
    {
        var ball = other.gameObject;
        //Debug.Log("Collider");
        if (pinballs.Count > 1)
        {
            pinballs.Remove(other.gameObject);
            DestroyObject(other.gameObject);
        }
        else
        {
            //var winner = ball.GetComponent<Ball>().Theme;
            var winner = pinballs.First().gameObject.GetComponent<Ball>().Theme;
            Debug.Log(winner);
            text.text = winner;
            using(var sw = new StreamWriter("winner.txt"))
            {
                sw.Write(winner);
                sw.Close();
            }
        }
    }
}
