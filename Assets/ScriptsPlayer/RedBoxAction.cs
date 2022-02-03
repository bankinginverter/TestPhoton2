using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RedBoxAction : MonoBehaviour
{
    public event Action redBoxAction;

    private void Update()
    {
        redBoxAction?.Invoke();
    }
}
