using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    private List<key.KeyCode> keys;
    private void Awake()
    {
        keys = new List<key.KeyCode>();
    }

    public void AddKey(key.KeyCode keyCode)
    {
        keys.Add(keyCode);
    }

    public void removeKey(key.KeyCode keyCode)
    {
        keys.Remove(keyCode);
    }

    public bool containsKey(key.KeyCode keyCode)
    {
        return keys.Contains(keyCode);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        key key = collision.GetComponent<key>();
        if (key != null)
        {
            AddKey(key.GetKeyCode());
            Destroy(key.gameObject);
        }
        KeyDoor keyDoor = collision.GetComponent<KeyDoor>();
        if (keyDoor != null)
        {
            if (containsKey(keyDoor.GetKeyCode()))
            {
                keyDoor.OpenDoor();
            }
        }
    }


}