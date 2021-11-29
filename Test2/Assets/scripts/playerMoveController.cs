using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class playerMoveController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;

    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private float moveSpeed;

        // Start is called before the first frame update
        void FixedUpdate()
        {
            if (joystick.Horizontal != 0)
            {
                rigidbody.velocity = new Vector3(joystick.Horizontal * moveSpeed, -1, 0);
            }
        }
}
