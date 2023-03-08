using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTeleport : MonoBehaviour
{
    public Transform Teleport_Point;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Teleport_Point.transform.position;
    }
}
