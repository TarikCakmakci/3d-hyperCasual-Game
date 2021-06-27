using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public enum SIDE { Sol, Orta, Sag }

public class Hareket : MonoBehaviour
{

    public SIDE m_Side = SIDE.Orta;
    float YeniXPoz = 0f;
    public bool SolaKaydir;
    public bool SagaKaydir;
    public float XDegeri;
    private Animator m_Animator;
    private CharacterController m_char;
    public float GecisHizi;
    public float FwdSpeed = 3f;
    private float x;
    private float y;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_char = GetComponent<CharacterController>();
        transform.position = Vector3.zero;
        

    }

    void Update()
    {
        SolaKaydir = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow);
        SagaKaydir = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.RightArrow);
        if (SolaKaydir)
        {
            if (m_Side == SIDE.Orta)
            {
                YeniXPoz = -XDegeri;
                m_Side = SIDE.Sol;
                m_Animator.Play("RightDodge");

            } else if (m_Side == SIDE.Sag)
            {
                YeniXPoz = 0;
                m_Side = SIDE.Orta;
                m_Animator.Play("RightDodge");
            }

        }
        else if (SagaKaydir)
        {
            if (m_Side == SIDE.Orta)
            {
                YeniXPoz = XDegeri;
                m_Side = SIDE.Sag;
                m_Animator.Play("LeftDodge");

            }
            else if (m_Side == SIDE.Sol)
            {
                
                YeniXPoz = 0;
                m_Side = SIDE.Orta;
                m_Animator.Play("LeftDodge");
            }

        }
        Vector3 moveVector = new Vector3(x - transform.position.x, y*Time.deltaTime, -FwdSpeed*Time.deltaTime);
        x = Mathf.Lerp(x, YeniXPoz, Time.deltaTime * GecisHizi);
        m_char.Move(moveVector);
    }
}
