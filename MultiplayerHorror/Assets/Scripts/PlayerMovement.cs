using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region "Variables"
    public Rigidbody Rigid;
    public Camera playerView;
    public float MouseSensitivity;
    public float MoveSpeed;
    public float JumpForce;
    #endregion

    void Update()
    {
        playerView.transform.rotation = playerView.transform.rotation * Quaternion.Euler(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X") * MouseSensitivity, 0));
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
        if (Input.GetKeyDown("space"))
        {
            Rigid.AddForce(transform.up * JumpForce);
        }
    }
}
