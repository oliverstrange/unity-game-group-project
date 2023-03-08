using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarLifeManager : MonoBehaviour
{

    
    private float currentHealth;

    //UI components
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;
    [SerializeField] private float startingHealth;
    [SerializeField] public GameObject die;

   


    private void Awake()
    {

        currentHealth = startingHealth;
        totalHealthBar.fillAmount = currentHealth / 10;
        die.SetActive(false);
    }

    // Start is called before the first frame update
    private void Start()
    {
      

    }

    private void Update()
    {
        currentHealthBar.fillAmount = currentHealth / 10 ;
    }


    public float GetHealth()
    {
        return currentHealth;
    }

    
    //Called when avatar loses a life
    public void TakeDamage()
    {
        currentHealth -- ;
        Debug.Log("Life has been lost, life totals is now " + currentHealth);

        if (currentHealth == 0)
        {
            Die(true);
        }
        
    }


    //Called when a meat is consuumed (extra life)
    public void AddLife()
    {
        if(currentHealth < 3)
        {
            currentHealth++;
            Debug.Log("Life has been added, life totals is now " + currentHealth);
        }
        else
        {
            Debug.Log("Life has not been added, life totals is at max ");
        }
         
    }

    //Called when avatar has no remaining lives
    public void Die(bool status)
    {
   
        die.SetActive(status);

        
    }


    
}
