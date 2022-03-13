using UnityEngine;

/// <summary>
/// This class inherits from TargetObject and represents a LapObject.
/// </summary>
public class LapObject : TargetObject
{
    [Header("LapObject")]
    [Tooltip("Is this the first/last lap object?")]
    public bool finishLap;

    [HideInInspector]
    public bool lapOverNextPass;


    PickupObject[] pickupObjects;

    void Start() {
        pickupObjects = FindObjectsOfType<PickupObject>();
        Register();
    }
    
    void OnEnable()
    {
        lapOverNextPass = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((layerMask.value & 1 << other.gameObject.layer) > 0 && (other.gameObject.CompareTag("Player")))
        {

            CheckpointCounter counter = other.gameObject.transform.parent.gameObject.GetComponent<CheckpointCounter>();
            if (pickupObjects.Length == counter.checkpoints)
            {
                GameFlowManager gameManager = GameObject.Find("GameManager").GetComponent<GameFlowManager>();


                if (other.gameObject.transform.parent.gameObject.CompareTag("Player"))
                {
                    gameManager.playerWin = true;
                }
                else
                {
                    gameManager.botWin = true;
                }

            }

        }
        //Objective.OnUnregisterPickup?.Invoke(this);
    }
}
