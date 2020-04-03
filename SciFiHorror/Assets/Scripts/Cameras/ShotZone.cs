using UnityEngine;
using System.Collections;
public class ShotZone : MonoBehaviour
{
    public Shot targetShot;
    void OnTriggerStay(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            targetShot.CutToShot();
        }
    }
}