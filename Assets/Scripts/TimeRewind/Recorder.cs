using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Recorder : MonoBehaviour
{
    public abstract void Pause();
    public abstract void Resume();
    public abstract void RestoreFrame(int frame);
}

public abstract class Recorder<T> : Recorder
{
    protected virtual void Update()
    {
        if (DifferFromLast())
        Record();
    }

    protected abstract void Record();

    protected abstract bool DifferFromLast();
}