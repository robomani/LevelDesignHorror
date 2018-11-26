using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoor : MonoBehaviour
{
    [SerializeField]
    private Transform DoorClosed;
    [SerializeField]
    private Transform DoorOpen;
    [SerializeField]
    private float MoveSpeed = 1.5f;

	public void TriggerDoor(bool? i_OpenDoor = null)
    {
        if (i_OpenDoor == null)
        {
            if (transform.rotation == DoorClosed.rotation)
            {
                StartCoroutine(MoveDoor(DoorOpen, MoveSpeed));
            }
            else
            {
                StartCoroutine(MoveDoor(DoorClosed, MoveSpeed));
            }
        }
        else
        {
            if (i_OpenDoor == true)
            {
                StartCoroutine(MoveDoor(DoorOpen, MoveSpeed));
            }
            else
            {
                StartCoroutine(MoveDoor(DoorClosed, MoveSpeed));
            }
        }
    }

    private IEnumerator MoveDoor(Transform i_EndPos, float i_Time = 1.5f)
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = i_EndPos.position;
        Quaternion startRot = transform.rotation;
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
            transform.position = Vector3.Lerp(startPos, endPos, value);
            transform.rotation = Quaternion.Slerp(startRot, endRot, value);
            yield return new WaitForEndOfFrame();
        }
    }
}
