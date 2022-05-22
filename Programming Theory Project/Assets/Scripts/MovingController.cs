using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingController : MonoBehaviour
{
    private float m_jumpForce = 3.0f;
    public float JumpForce
    {
        get { return m_jumpForce; }
        set
        {
            if(value < 0.0f) {
                Debug.Log("Invalid force!");
            }else {
                m_jumpForce = value;
            }
        }
    }

    private float m_Speed = 3.0f;
    public float Speed
    {
        get { return m_Speed; }
        set
        {
            if(value < 0.0f) {
                Debug.LogError("Invalid speed!");
            }else {
                m_Speed = value;
            }
        }
    }

    public virtual void Walk(float v_input)
    {
        transform.Translate(Vector3.right * Time.deltaTime * m_Speed * v_input);
    }

    public virtual void Turn(float h_input)
    {
        transform.Translate(Vector3.back * Time.deltaTime * m_Speed * h_input);
    }

    public virtual void Jump(Rigidbody player)
    {
        player.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
    }
}
