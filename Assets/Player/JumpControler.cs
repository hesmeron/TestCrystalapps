using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControler : MonoBehaviour
{
    [SerializeField]
    float jumpHeight = 2f;
    private bool jumped = false;
    Vector3 jumpPosition;
    [SerializeField]
    float jumpLength = 3;
    // Update is called once per frame
    void Update()
    {
        if (PlayerInput.CheckJumpInput() && !jumped)
        {
            Jump();
        }
        if (jumped && Vector3.Distance(jumpPosition, this.transform.position) > jumpLength)
        {
            FallDown();
        }
    }

    void Jump()
    {
        Debug.Log("Jump");
        this.transform.position += new Vector3(0, jumpHeight, 0);
        jumpPosition = this.transform.position;
        jumped = true;
    }

    void FallDown()
    {
        this.transform.position -= new Vector3(0, jumpHeight, 0);
        jumped = false;
    }
}
