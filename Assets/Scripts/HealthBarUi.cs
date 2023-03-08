using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarUi : MonoBehaviour
{

    
    private float currentHealth;

    //UI components
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;
    [SerializeField] private float startingHealth;
    [SerializeField] private Health dogLife;
    private GameObject obj;

   


    private void Start()
    {

        obj = GameObject.FindWithTag("Player");
        dogLife = obj.GetComponent<Health>();

        totalHealthBar.fillAmount = dogLife.currentHealth / 10;
     
    }

   

    private void Update()
    {
        currentHealth = dogLife.currentHealth;
        currentHealthBar.fillAmount = currentHealth / 10 ;
    }



    
}
