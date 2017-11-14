using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public string key;

    public float restPosition = 0f;
    public float pressedPosition = -45f;
    public float hitStrength = 100000f;
    public float flipperDamper = 100f;
    public float fireRate = 1;
    public float pressLag = .2f;
    private float currentTime;
    HingeJoint hinge;
    

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().maxAngularVelocity = 100;
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    currentTime += Time.deltaTime;
	    //Debug.Log(currentTime);
        if (currentTime > fireRate)
	    {
            if (currentTime > fireRate + pressLag)
	        {
	            currentTime = 0;
	        }

	        PressKey(key, true);
        }

	    PressKey(key, false);
    }

    private void PressKey(string key, bool pressed)
    {
        JointSpring spring = new JointSpring()
        {
            spring = hitStrength,
            damper = flipperDamper
        };

        if (Input.GetKey(key) || pressed)
        {
            //Debug.Log("KeyPressed" + " currentTime: " + currentTime);
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
