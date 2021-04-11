using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingBall : MonoBehaviour
{
    public float speed = 3f;

    public Rigidbody rigid;
    public float horizontal;
    public float vertical;

    public LayerMask groundLayers;

    public float jumpForce = 7;

    public CapsuleCollider col;

    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

        rigid.AddForce(direction * speed);


        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        { 
           rigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    } 
    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
        
    }
}