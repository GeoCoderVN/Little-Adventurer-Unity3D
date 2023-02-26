using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect FootStep;
    public VisualEffect AttackVFX;

    public void BurstFootStep()
    {
        FootStep.SendEvent("OnPlay");
    }
    public void PlayAttackVFX()
    {
        AttackVFX.SendEvent("OnPlay");
    }


}
