using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coche : MonoBehaviour {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public float maxMotorTorque;
    public float maxSteeringAngle;
    public float brakeForce;
    public Text txtSpeed;
    private Rigidbody rbCoche;
    private void Awake()
    {
        rbCoche = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        txtSpeed.text = rbCoche.velocity.magnitude.ToString();//Mostramos la velocidad en la UI
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        if (Mathf.Abs(steering)>0)
        {
            leftWheel.steerAngle = steering;
            rightWheel.steerAngle = steering;
        }
        if (Mathf.Abs(motor)>0)
        {
            leftWheel.motorTorque = motor;
            rightWheel.motorTorque = motor;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            leftWheel.motorTorque = 0;
            rightWheel.motorTorque = 0;
            leftWheel.brakeTorque = leftWheel.brakeTorque + brakeForce;
            rightWheel.brakeTorque = leftWheel.brakeTorque + brakeForce;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            leftWheel.brakeTorque = 0;
            rightWheel.brakeTorque = 0;
        }
    }
}
