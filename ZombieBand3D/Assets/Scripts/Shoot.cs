﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 5.0f;
    public float range = 50.0f;

    public Camera cam;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
      
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(point); 
            if (Physics.Raycast(ray, out hit ,range))
            {
                Debug.Log(hit.transform.name);

                DieEnemy enemy = hit.transform.GetComponent<DieEnemy>();
                if (enemy != null)
                {
                    enemy.ReactToHit();
                }

            }
        }
    }

    void OnGUI()
    {
        float posX = cam.pixelWidth / 2;
        float posY = cam.pixelHeight / 2;
        GUI.Label(new Rect(posX, posY, 12, 12), "*");//команда GUI.Label() отображает символ *
    }
}
