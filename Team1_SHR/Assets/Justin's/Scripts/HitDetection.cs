using UnityEngine;

public class HitDetection : MonoBehaviour
{
    ////////////////////////////////////////
    // Checklist
    ////////////////////////////////////////

    // 1) I want to see if we are hitting something.
    // 2) I want to see if it was a car.
    // 3) I want to see from what direction the hitter hit the collider. Either: front, back, left, right

    ////////////////////////////////////////
    // Fields
    ////////////////////////////////////////

    // The text that will tell me what direction it is hitting. Is a variable so that it can change.
    string dirS = "placeholder";
    float dirX;
    float dirZ;
    float dot;
    Vector3 dir;

    ////////////////////////////////////////
    // Enumerations
    ////////////////////////////////////////

    // Allows me to create constrants. Side note: This is a full statement, so it needs a ;.
    // Other side note about enums: None currently reads 0, None = 0. I can change this by writing it out like, None = 1, changing the starting point. I can further changes this and assign each constrant its own value.
    // I can also change the type that is being used, like float or string by adding a colon: enum HitDirection : float{...
    enum HitDirection { None, Forward, Back, Left, Right };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ////////////////////////////////////////
    // Collision Events
    ////////////////////////////////////////

    // Start of the code is here.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Car")
        {
            //              hitter                reciever
            CheckDirection(collision.gameObject, this.gameObject);

            #region // Console checks for debugging purposes.
            //print(collision.gameObject.name + " hit me from " + dirS + "!");
            //Debug.Log(dirX + ", X direction");
            //Debug.Log(dirZ + ", Z direction");
            //Debug.Log(dir + ", Vector3");
            //Debug.Log(dot + ", Dot Product");
            #endregion
        }
    }

    ////////////////////////////////////////
    // Checks for Methods
    ////////////////////////////////////////

    // 1) I want to grab the information from the collision event to determine the hitter and reciever.
    // 2) I want to determine what direction they got hit from and return that information.
    HitDirection CheckDirection(GameObject hitter, GameObject reciever)
    {
        // Start by "refreshing" hitDirection.
        HitDirection hitDirection = HitDirection.None;

        // Grabs the collision info and subtracts their values. After which, we will normalize to get a whole #.
        // Hitter - Reciever = positive/negative
        // By determining if the Vector is positive or negative, we can later determine where the hitter came from.
        dir = (hitter.transform.position - reciever.transform.position).normalized;
        dot = Vector3.Dot(hitter.transform.position, reciever.transform.position);
        

        return hitDirection;
    }
}
