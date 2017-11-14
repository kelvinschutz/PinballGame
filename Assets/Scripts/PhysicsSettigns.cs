using UnityEngine;

public class PhysicsSettigns : MonoBehaviour {

    private Rigidbody _rigidBody;

	void Start () {
        _rigidBody = gameObject.GetComponent<Rigidbody>();

        //_rigidBody.maxAngularVelocity = 30;
	}
	
	void Update () {
		
	}
}
