using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCounter : MonoBehaviour
{
    [Tooltip("Tak")]
    public int checkpoints = 0;

    public void Increment()
    {
        checkpoints += 1;
    }
}
