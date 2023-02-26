using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect FootStep;
    public VisualEffect AttackVFX;
    public ParticleSystem BeingHitVXF;

    public VisualEffect BeingHitSplashVXF;

    public void BurstFootStep()
    {
        FootStep.SendEvent("OnPlay");
    }
    public void PlayAttackVFX()
    {
        AttackVFX.SendEvent("OnPlay");
    }

    public void PlayBeingHitVXF(Vector3 attackerPos)
    {
        Vector3 forceForward = transform.position - attackerPos;
        forceForward.Normalize();
        forceForward.y = 0;
        BeingHitVXF.transform.rotation = Quaternion.LookRotation(forceForward);
        BeingHitVXF.Play();
        Vector3 splashPos = transform.position;
        splashPos.y += 2f;
        VisualEffect newSplashVXF = Instantiate(BeingHitSplashVXF, splashPos, Quaternion.identity);
        newSplashVXF.SendEvent("OnPlay");
        Destroy(newSplashVXF.gameObject, 10f);
    }

}
