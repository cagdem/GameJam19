using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRecorder : Recorder
{
    private List<Vector3> m_recordedPositions = new List<Vector3>();
    private List<Quaternion> m_recordedRotations = new List<Quaternion>();

    // Update is called once per frame
    void Update()
    {
        Record();
    }

    private void Record()
    {
        m_recordedPositions.Add(transform.position);
        m_recordedRotations.Add(transform.rotation);
    }

    public override void Pause()
    {
    }

    public override void Resume()
    {
    }

    public override void RestoreFrame(int frame)
    {
        Debug.Assert(m_recordedPositions.Count > frame);
        transform.position = m_recordedPositions[frame];
        transform.rotation = m_recordedRotations[frame];
    }
}
