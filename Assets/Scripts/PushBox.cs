using UnityEngine;
using System.Collections;

public class PushBox : MonoBehaviour
{
    private GameObject Player;
    private MergeAttachDetach arm;
    private Rigidbody2D rgbd;
    private Animator myAnimator;
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

        

        if (Input.GetKeyDown(KeyCode.H)) //&& (darm.hasArm || arm.hasSecondArm))
        {
            
            //rgbd.constraints = RigidbodyConstraints2D.None;
            gameObject.layer = 11;
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            gameObject.transform.position = start;
            gameObject.layer = 8;
          // rgbd.constraints = RigidbodyConstraints2D.FreezeAll;
        }
       /* if (!arm.hasArm || !arm.hasSecondArm)
        {
            //
        }*/


    }

}

   /* void OnCollisonEnter(Collider2D other)
    {
            if (other.name == "death")
            {
                Debug.Log("im pushing");
            }

    }
}*/
