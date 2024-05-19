using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RigidbodyRecorder : Recorder<Rigidbody>
{
    private FrameRecordContainer<Vector3> m_recordedVelocities = new();
    private FrameRecordContainer<Vector3> m_recordedAngularVelocities= new();

    public PlaybackController PlaybackController { get; set; }
    public Rigidbody Rigidbody { get; set; }

    protected override void Record()
    {
        m_recordedVelocities.Add(Rigidbody.velocity);
        m_recordedAngularVelocities.Add(Rigidbody.angularVelocity);
    }

    public override void RestoreFrame(int frame)
    {
    }  
    
    public override void Pause()
    {
        Rigidbody.isKinematic = true;
    }


    public override void Resume()
    {
        Rigidbody.isKinematic = false;
        Rigidbody.velocity = m_recordedVelocities.Get(PlaybackController.Frame);
        Rigidbody.angularVelocity = m_recordedAngularVelocities.Get(PlaybackController.Frame);
    }

    protected override bool DifferFromLast()
    {
        var velocity = m_recordedVelocities.Get(PlaybackController.Frame);
        var angularVelocity = m_recordedAngularVelocities.Get(PlaybackController.Frame);

        if (Rigidbody.velocity == velocity && Rigidbody.angularVelocity == angularVelocity)
        {
            return false;
        }

        return true;
    }
}

public class FrameRecordContainer<T>
{
    private Dictionary<int,T> m_records = new();
    public PlaybackController PlaybackController { get; set; }

    public void Add(T record)
    {
        m_records.Add(PlaybackController.Frame,record);
    }

    public T Get(int frame)
    {
        if (m_records.TryGetValue(frame, out var record))
        {
            return record;    
        }
        
         var allKeys = m_records.Keys.ToArray();
         for (int i = allKeys.Length -1; i >= 0; i--)
         {
             if (allKeys[i] <= frame)
             {
                 return m_records[allKeys[i]];
             }
         }
         return default;    
    }
}