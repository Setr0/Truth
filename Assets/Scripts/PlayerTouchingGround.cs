using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchingGround : MonoBehaviour
{
    public static bool isTouchingGround = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isTouchingGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isTouchingGround = false;
    }
}
