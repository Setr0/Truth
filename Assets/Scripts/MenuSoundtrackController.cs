using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSoundtrackController : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
