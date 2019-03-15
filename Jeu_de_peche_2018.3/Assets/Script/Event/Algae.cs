﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algae : MonoBehaviour
{
    private GameObject Player;
    private float LantLight;
    public GameObject m_fire2;
    public GameObject m_fire3;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay(Collider other)
    {
        LantLight = Player.GetComponentInChildren<LanternScript>().currentLanternLight;

        if (other.tag == "Player")
        {
            if (Input.GetButton("Interact") && LantLight > 20)
            {
                m_fire2.SetActive(true);
                m_fire3.SetActive(true);
                m_fire2.GetComponentInChildren<Light>().enabled = false;
                m_fire3.GetComponentInChildren<Light>().enabled = false;
                this.transform.parent.gameObject.SetActive(false);
                //gameObject.SetActive(false);
                LantLight = LantLight - 20;
                Player.GetComponentInChildren<LanternScript>().currentLanternLight = LantLight;

            }
        }
    }
}
