
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    [SerializeField]
   public Image JumpForceBar;

    float holdTime;

    public GameObject @Player;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        JumpForceBar.fillAmount = 0f;
        
    }

    public void OnPointerDown()
    {
        JumpForceBar.fillAmount = 0f;
        StartCoroutine(nameof(StartCounting));

    }

    public void OnPointerUp()
    {
        
        StopCoroutine(nameof(StartCounting));

        if (holdTime < 0.3f)
            Playerr.DoJump(300f);
   
            Playerr.DoJump(holdTime * 1000f);

        JumpForceBar.fillAmount = 0f;

        
    }

    IEnumerator StartCounting()
    {
        for (holdTime = 0f; holdTime <= 1f; holdTime += Time.deltaTime)
        {

            JumpForceBar.fillAmount = holdTime;
            yield return new WaitForSeconds(Time.deltaTime);

        }
        holdTime = 1f;
        JumpForceBar.fillAmount = holdTime;
    }

}