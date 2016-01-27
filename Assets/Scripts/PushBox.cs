using UnityEngine;
using System.Collections;

public class PushBox : MonoBehaviour
{
    private GameObject Player;
    private MergeAttachDetach arm;
    private Rigidbody2D rgbd;
    private Animator myAnimator;
	Vector3 temp = new Vector3(.4f,0,0);
    Vector3 start;
    //private int myState;

    // Use this for initialization
    void Start()
    {
        //myState = myAnimator.GetInteger("state");
        // myAnimator = GetComponent<Animator>();
        start = gameObject.transform.position;
        Player = GameObject.Find("Player");
        arm = Player.GetComponent<MergeAttachDetach>();
        rgbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //myState = myAnimator.GetInteger("state");
        Debug.Log(gameObject.transform.position.x);
		start = gameObject.transform.position;
        

        if (Input.GetKeyDown(KeyCode.H) && (arm.hasArm || arm.hasSecondArm))
        {
			//rgbd.constraints = RigidbodyConstraints2D.None;
			rgbd.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
            //rgbd.constraints = RigidbodyConstraints2D.None;
            gameObject.layer = 11;
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            //gameObject.transform.position = start;

			rgbd.constraints = RigidbodyConstraints2D.FreezeAll;
			gameObject.layer = 8;
			gameObject.transform.position += temp;
        }
    }

}

