using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaybackController : MonoBehaviour
{
    public static PlaybackController Instance;
    private bool m_isPlayback = false; // false = recording, true = playback
    private int m_playbackFrame = 0;
    private int m_playbackSpeed = 0;
    public List<Recorder> m_recorders;

    public int Frame => m_playbackFrame;
    public bool IsPlayback => m_isPlayback;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (m_isPlayback)
        {
            m_playbackFrame = Mathf.Max(0, m_playbackFrame - m_playbackSpeed);
            RestoreFrame();
        }
        else
        {
            m_playbackFrame++;
        }

        if (m_playbackFrame <= 0)
        {
            StopPlayback();
        }
    }

    public void Pause()
    {
        StartPlayback();
        foreach (var recorder in m_recorders)
        {
            recorder.Pause();
        }
    }

    public void Resume()
    {
        StopPlayback();
        foreach (var recorder in m_recorders)
        {
            recorder.Resume();
        }
    }

    public void RestoreFrame()
    {
        foreach (var recorder in m_recorders)
        {
            recorder.RestoreFrame(m_playbackFrame);
        }
    }

    public void StartPlayback()
    {
        m_isPlayback = true;
        m_playbackSpeed = 0;
    }

    public void StopPlayback()
    {
        m_isPlayback = false;
        m_playbackSpeed = 0;
    }

    public void StartReversing() 
    {
        m_isPlayback = true;
        m_playbackSpeed += 1;
    }
}

