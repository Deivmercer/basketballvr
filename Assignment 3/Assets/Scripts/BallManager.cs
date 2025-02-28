using System.Collections;
using System.Collections.Generic;
using Meta.WitAi;
using Unity.VisualScripting;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject ballInstance;

    private readonly Vector3 _defaultPosition = new(0, 1, 0.5f);

    private Rigidbody _ballRigidBody;
    
    private PhysicMaterial _ballMaterial;

    void Start()
    {
        _ballRigidBody = ballInstance.GetComponent<Rigidbody>();

        ResetBall();
    }

    public void ResetBall()
    {
        ballInstance.transform.position = _defaultPosition;
        ballInstance.transform.rotation = Quaternion.identity;
        
        _ballRigidBody.velocity = Vector3.zero;
        _ballRigidBody.angularVelocity = Vector3.zero;
        _ballRigidBody.useGravity = false;
        _ballRigidBody.isKinematic = true;
    }

    public void OnBallGrabbed()
    {
        _ballRigidBody.useGravity = true;
        _ballRigidBody.isKinematic = false;
    }
}
