using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerVXFManager : MonoBehaviour
{
    public VisualEffect footStep;

    public ParticleSystem Blade01;

    public void Update_FootStep(bool state)
    {
        if (state)
            footStep.Play();
        else
            footStep.Stop();

    }

    public void PlayBlade01()
    {
        Blade01.Play();
    }
}
