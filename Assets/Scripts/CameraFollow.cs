// using UnityEngine;

// public class CameraFollow : MonoBehaviour {


//     public Transform target;
//     public float smoothSpeed = 0.125f;
//     public Vector3 offset;

//     void LateUpdate()
//     {
//         Vector3 desiredPosition = target.position + offset;
//         Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
//         transform.position = new Vector3(smoothedPosition.x, transform.position.y, transform.position.z);
//     }
// }

// using UnityEngine;
// public class CameraFollow : MonoBehaviour
// {
//     public Transform target;
//     public float smoothSpeed = 0.125f;
//     public Vector3 offset;

//     void LateUpdate()
//     {
//         Vector3 desiredPosition = target.position + offset;
//         Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
//         transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
//     }
// }

// using UnityEngine;

// public class CameraFollow : MonoBehaviour
// {

//     public Transform Target;
//     public float smoothSpeed = 0.125f;
//     public Vector3 offset;

//     void LateUpdate()
//     {
//         Vector3 desiredPosition = Target.position + offset;
//         Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
//         transform.position = new Vector3(smoothPosition.x, smoothPosition.y, transform.position.z);
//     }


// }

// using UnityEngine;
// public class CameraFollow : MonoBehaviour
// {
//     public Transform Target;

//     public float smoothSpeed = 0.125f;
//     public Vector3 offset;



//     void LateUpdate()
//     {
//         Vector3 desiredPosition = Target.position + offset;
//         Vector3 smoothPosition =  Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
//         transform.position = new Vector3(smoothPosition.x, smoothPosition.y, transform.position.z);
//     }

// }

using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = Target.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothposition.x, smoothposition.y, transform.position.z);
        
     }
}