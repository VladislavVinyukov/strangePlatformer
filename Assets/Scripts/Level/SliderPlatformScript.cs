using UnityEngine;

public class SliderPlatformScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            SliderJoint2D sliderJoint2D = collision.gameObject.GetComponent<SliderJoint2D>();
            JointMotor2D jointMotor2D = sliderJoint2D.motor;
            sliderJoint2D.motor = new JointMotor2D { motorSpeed = -jointMotor2D.motorSpeed, maxMotorTorque= 10000 };
        }
        
    }
}
