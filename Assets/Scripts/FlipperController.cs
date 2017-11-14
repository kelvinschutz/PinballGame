using UnityEngine;

public class FlipperController : MonoBehaviour {

    public GameObject _leftPivot;
    private Quaternion _leftRestRotation;
    public GameObject _rightPivot;
    private Quaternion _rightRestRotation;
    public int LEFT_END_ANGLE = -45;
    public int RIGHT_END_ANGLE = 45;
    public float RECOIL_SPEED = .5f;

    void Awake()
    {
        if(_leftPivot != null)
        {
            _leftRestRotation = _leftPivot.transform.rotation;
        }
        if(_rightPivot != null)
        {
            _rightRestRotation = _rightPivot.transform.rotation;
        }
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Left Flipper");
            var targetRotation = Quaternion.Euler(_leftRestRotation.eulerAngles + new Vector3(0, LEFT_END_ANGLE, 0));
            _leftPivot.transform.rotation = Quaternion.Lerp(_leftPivot.transform.rotation, targetRotation, Time.deltaTime * RECOIL_SPEED);
        }
        else
        {
            _leftPivot.transform.rotation = Quaternion.Lerp(_leftPivot.transform.rotation, _leftRestRotation, Time.deltaTime * RECOIL_SPEED);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Right Flipper");
            var targetRotation = Quaternion.Euler(_rightRestRotation.eulerAngles + new Vector3(0, RIGHT_END_ANGLE, 0));
            _rightPivot.transform.rotation = Quaternion.Lerp(_rightPivot.transform.rotation, targetRotation, Time.deltaTime * RECOIL_SPEED);
        }
        else
        {
            _rightPivot.transform.rotation = Quaternion.Lerp(_rightPivot.transform.rotation, _rightRestRotation, Time.deltaTime * RECOIL_SPEED);
        }
    }
}
