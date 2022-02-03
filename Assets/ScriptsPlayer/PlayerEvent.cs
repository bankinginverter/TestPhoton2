using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEvent : MonoBehaviour
{
    public RedBoxController redBoxController;
    public RedBoxAction redBoxAction;

    private void Awake()
    {
        redBoxAction.redBoxAction += OnMovePlayerEvent;
    }
    
    private void OnMovePlayerEvent()
    {
        redBoxController.OnMovePlayer();
    }

}
