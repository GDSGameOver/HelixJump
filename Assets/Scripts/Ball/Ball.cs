using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlatformSegment segment))
        {
            other.GetComponentInParent<Platform>().Break();
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out FinishPlatformSegment finishSegment))
        {
            collision.gameObject.GetComponentInParent<FinishPlatform>().Finish();
        }
    }
}
