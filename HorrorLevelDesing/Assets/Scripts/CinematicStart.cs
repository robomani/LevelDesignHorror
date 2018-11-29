using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CinematicStart : MonoBehaviour
{

    public PlayableDirector timeline;

    private void Start ()
    {
        Time.timeScale = 0.35f;
        timeline.Play();
    }

}
