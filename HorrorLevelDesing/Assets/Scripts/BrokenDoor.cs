using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenDoor : MonoBehaviour
{

    public float m_DoorToggleRate = 1.0f;

    public DoorController m_Door;
    public AudioClip m_Sound;
    public AudioSource m_Source;

    private bool m_Closing = true;
    private float m_Time = 0;

    private void Update()
    {
        if (m_Time >= m_DoorToggleRate)
        {
            m_Closing = !m_Closing;
            m_Time = 0;
            m_Door.MoveAllDoors();
            if (m_Closing)
            {
                m_Source.PlayOneShot(m_Sound);
            }

        }
        else
        {
            m_Time += Time.deltaTime;
        }
    }
}
