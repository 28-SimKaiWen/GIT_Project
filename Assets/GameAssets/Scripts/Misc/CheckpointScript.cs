﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private GameMasterScript gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMasterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(other.TryGetComponent<AmongUs>(out var player))
            {
                print("Respawn point set at: " + transform.position);
                gm.lastCheckPointPos = transform.position;
                player.SetRespawn(this.transform.position, this.transform.rotation);
            }
        }
    }
}
