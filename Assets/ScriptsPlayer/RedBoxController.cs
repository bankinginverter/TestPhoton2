using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Photon.Pun;
public class RedBoxController : PlayerController
{
    PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    public override void OnMovePlayer()
    {

        if (view.IsMine)
        {
            base.OnMovePlayer();
        }
    }


}
