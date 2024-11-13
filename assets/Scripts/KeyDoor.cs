using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private key.KeyCode keyCode;
    public key.KeyCode GetKeyCode()
    {
        return keyCode;
    }

    // Update is called once per frame
    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }
}

