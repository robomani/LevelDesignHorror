using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closer : MonoBehaviour
{
    public DoorController m_Door;
    private void OnEnable()
    {
        m_Door.MoveAllDoors(false);
    }

}
