// using UnityEngine;

// public class BackRound : MonoBehaviour
// {
//     public Transform cameraTransform;
//     public float parallaxEffectMultiplier = 0.5f;

//     [SerializeField] AudioClip BackRoundSound;

//     private AudioSource audioSource;
//     private Vector3 lastCameraPosition;

//     void Start()
//     {
//         lastCameraPosition = cameraTransform.position;

//         audioSource = GetComponent<AudioSource>();

//         // Setup Audio
//         audioSource.clip = BackRoundSound;
//         audioSource.loop = true;             
//         audioSource.playOnAwake = false;
//         audioSource.Play();                  
//     }

//     void LateUpdate()
//     {
//         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
//         transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, 0f, 0f);
//         lastCameraPosition = cameraTransform.position;
//     }
// }

// using UnityEngine;
// public class BackRound : MonoBehaviour
// {
//     public Transform cameraTransform;
//     public float parallaxEffectMultiplier = 0.5f;
//     public AudioClip BackRoundSound;
//     private AudioSource audioSource;

//     private Vector3 lastCameraPosition;


//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//         audioSource.clip = BackRoundSound;
//         audioSource.loop = true;
//         audioSource.playOnAwake = false;
//         audioSource.Play();

//     }


//     void LateUpdate()
//     {
//         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
//         transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, 0, 0);
//         lastCameraPosition = cameraTransform.position;
//     }
// }


// using UnityEngine;
// public class BackRound : MonoBehaviour
// {
//     public Transform cameraTransform;
//     public float parallaxEffectMultiplier = 0.5f;
//     public AudioClip BackRoundSound;
//     private AudioSource audioSource;

//     private Vector3 lastCameraPosition;


//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//         audioSource.clip = BackRoundSound;
//         audioSource.loop = true;
//         audioSource.playOnAwake = false;
//         audioSource.Play();

//     }


//     void LateUpdate()
//     {
//         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
//         transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, 0, 0);
//         lastCameraPosition = cameraTransform.position;
//     }
// }


// using UnityEngine;

// public class BackRound : MonoBehaviour
// {
//     public Transform cameraTransform;
//     public float parallaxEffectMultiplier = 0.5f;
//     public AudioClip BackRoundSound;
//     private AudioSource audioSource;
//     private Vector3 lastCameraPosition;
//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//         audioSource.clip = BackRoundSound;
//         audioSource.loop = true;
//         audioSource.playOnAwake = false;
//         audioSource.Play();

//     }

//     void LateUpdate()
//     {
//         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
//         transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, 0, 0);
//         lastCameraPosition = cameraTransform.position;
//     }

// }


// using UnityEngine;

// public class BackRound : MonoBehaviour
// {

//     public Transform cameraTransform;
//     public float parallaxEffectMultiplier = 0.5f;
//     public AudioClip BackRoundSound;
//     private AudioSource audioSource;
//     private Vector3 lastCameraPosition;

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//         audioSource.clip = BackRoundSound;
//         audioSource.loop = true;
//         audioSource.playOnAwake = false;
//         audioSource.Play();
//     }



//     void LateUpdate()
//     {
//         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
//         transform.position = new UnityEngine.Vector3(deltaMovement.x * parallaxEffectMultiplier, 0, 0);
//         lastCameraPosition = cameraTransform.position;

//     }
// }

using UnityEngine;

public class BackRound : MonoBehaviour
{
    public Transform cameraTransform;
    public float parallaxEffectMultiplier = 0.5f;
    public AudioClip BackRoundSound;
    private AudioSource audioSource;
    private Vector3 lastCameraPosition;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = BackRoundSound;
        audioSource.loop = true;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.Play();


    }


    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;

        transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, 0, 0);
        lastCameraPosition = cameraTransform.position;
    }
}