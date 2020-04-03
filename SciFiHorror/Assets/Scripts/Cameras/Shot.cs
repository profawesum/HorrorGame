using UnityEngine;
using System.Collections;
public class Shot : MonoBehaviour
{
    public Vector3 focalPoint;
    public GameObject audioListener;
    public float audioCutDelay = 1.0f;
    public void CutToShot()
    {
        //transform.LookAt(focalPoint);
        Camera.main.transform.position = transform.position;
        Camera.main.transform.rotation = transform.rotation;
        Invoke("MoveAudioListener", audioCutDelay);
    }
    public void MoveAudioListener()
    {
        audioListener.transform.position = transform.position;
    }
    void OnDrawGizmosSelected()
    {
        if (!Application.isPlaying)
        {
            CutToShot();
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, focalPoint);
    }
}