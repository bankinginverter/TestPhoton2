using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    
    public virtual void OnMovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        this.transform.Translate(h, 0f, v);
    }
    

    PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (view.IsMine)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            this.transform.Translate(h * Time.deltaTime, 0f, v * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PhotonNetwork.Instantiate("Sphere", transform.position, transform.rotation);
            }
        }
    }
}
