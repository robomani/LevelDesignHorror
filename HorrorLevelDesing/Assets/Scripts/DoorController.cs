using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct DoorStruct
{
    public string m_DoorName;
    public bool m_Open;
    public GameObject m_Door;
    public Transform m_DoorClosed;
    public Transform m_DoorOpen;
}

public class DoorController : MonoBehaviour
{
    


    public List<DoorStruct> m_Doors = new List<DoorStruct>();

    public float MoveSpeed = 0.25f;

    public void MoveAllDoors(bool? i_OpenDoor = null, float i_Time = 0.25f)
    {
        foreach (DoorStruct door in m_Doors)
        {
            MoveOneDoor(door, i_OpenDoor);
        }    
    }
    
    public void MoveOneDoor(DoorStruct i_Door, bool? i_OpenDoor = null, float i_Time = 0.25f)
    {
        if (i_OpenDoor == null)
        {
            //i_Door.m_Open = !i_Door.m_Open;
            if (i_Door.m_Door.transform.position == i_Door.m_DoorOpen.position)
            {
                
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorClosed));
            }
            else
            {
                //i_Door.m_Open = true;
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorOpen));
            }
        }
        else
        {
            if (i_OpenDoor == false)
            {
                i_Door.m_Open = true;
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorClosed));
            }
            else
            {
                i_Door.m_Open = false;
                StartCoroutine(MoveDoor(i_Door.m_Door, i_Door.m_DoorOpen));
            }
        }
    }

    private IEnumerator MoveDoor(GameObject i_Door, Transform i_EndPos, float i_Time = 0.25f)
    {
        Debug.Log(i_Door.name);
        Vector3 startPos = i_Door.transform.position;
        Vector3 endPos = i_EndPos.position;
        Quaternion startRot = i_Door.transform.rotation;
        Quaternion endRot = i_EndPos.rotation;
        float currentTime = 0f;

        //yield return new WaitForSeconds(0.2f);
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
    
}
