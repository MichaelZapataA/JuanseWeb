using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains;
using MoreMountains.Tools;

public class EasterEggAchv : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Revision");
        if (other.CompareTag("Player"))
        {
            MMAchievementManager.UnlockAchievement("EasterEgg");
        }
    }
}
