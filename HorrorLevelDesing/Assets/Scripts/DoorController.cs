using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DoorController : MonoBehaviour
{
    public class DoorStruct
    {
        public string m_DoorName;
        public bool m_Open;
        //public GameObject m_Door;
        //public Transform m_DoorClosed;
        //public Transform m_DoorOpen;
    }


    public List<DoorStruct> m_Doors = new List<DoorStruct>();

    private float MoveSpeed = 1.5f;
/*
    public void MoveAllDoors(bool? i_OpenDoor = null, float i_Time = 1.5f)
    {
        foreach (DoorStruct door in m_Doors)
        {
            MoveOneDoor(door, i_OpenDoor);
        }    
    }
    
    public void MoveOneDoor(DoorStruct i_Door, bool? i_OpenDoor = null, float i_Time = 1.5f)
    {
        if (i_OpenDoor == null)
        {
            if (i_Door.m_Open)
            {
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorClosed));
            }
            else
            {
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorOpen));
            }
        }
        else
        {
            if (i_OpenDoor == false)
            {
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorClosed));
            }
            else
            {
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorOpen));
            }
        }
    }

    private IEnumerator MoveDoor(GameObject i_Door, Transform i_EndPos, float i_Time = 1.5f)
    {
        Vector3 startPos = i_Door.transform.position;
        Vector3 endPos = i_EndPos.position;
        Quaternion startRot = i_Door.transform.rotation;
        Quaternion endRot = i_EndPos.rotation;
        float currentTime = 0f;

        yield return new WaitForSeconds(0.2f);
        float value = 0.0f;

        while (currentTime != i_Time)
        {
            currentTime += Time.deltaTime;
            if (currentTime > i_Time)
            {
                currentTime = i_Time;
            }

            value = currentTime / i_Time;
            i_Door.transform.position = Vector3.Lerp(startPos, endPos, value);
            i_Door.transform.rotation = Quaternion.Slerp(startRot, endRot, value);
            yield return new WaitForEndOfFrame();
        }
    }
    */
}
