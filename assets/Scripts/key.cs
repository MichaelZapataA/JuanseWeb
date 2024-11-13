using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    [SerializeField] private KeyCode keyCode;


    public enum KeyCode
    {
        Red,
        Green,
        Blue,
    }

    public KeyCode GetKeyCode()
    {
        return keyCode;
    }
}
