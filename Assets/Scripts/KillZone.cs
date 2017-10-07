using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour {

    public float Damage = 100f;
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        if (PlayerControl.PlayerInstance != null)
            PlayerControl.Health -= Damage * Time.deltaTime;
    }
}
