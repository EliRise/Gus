using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Photon.Pun;


public class Player : MonoBehaviour
{
    public float _speed = 0.2f;
    public PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }


 
    

    void Update()
    {
       
        Vector3 acceleration = Input.acceleration;

        Vector3 movement = new Vector3(acceleration.x, acceleration.y, 0.0f);
        //movement.Normalize();
        transform.Translate(movement * _speed * Time.deltaTime);

    }
    

}
