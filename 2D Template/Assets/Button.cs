
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    [SerializeField]
    Image JumpForceBar;

    float holdTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        JumpForceBar.fillAmount = 0f;
    }

    public void OnPointerDown()
    {
        JumpForceBar.fillAmount = 0f;
        StartCoroutine("Startcounting");

    }

    public void OnPointerUp()
    {
        StopCoroutine("StartCounting");

        if (holdTime < 0.3f)
            Playerr.DoJump(300f);
        else
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