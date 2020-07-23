using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private string horizontalInputName;
    [SerializeField]
    private string verticalInputName;
    private float movementSpeed;
    [SerializeField]
    private float runSpeed, walkSpeed;
    [SerializeField]
    private float runBuildUpSpeed;
    [SerializeField]
    private KeyCode runKey;
    [SerializeField]
    private float slopeForce;
    [SerializeField]
    private float slopeForceRayLength;
    [SerializeField]
    private AnimationCurve jumpFallOff;
    [SerializeField]
    private float jumpMultiplier;
    [SerializeField]
    private KeyCode jumpKey;

    private bool isJumping;

    private CharacterController controller;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }


    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName);
        float vertInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        controller.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * movementSpeed);

        if ((horizInput != 0 || vertInput != 0) && OnSlope())
        {
            controller.Move(Vector3.down * controller.height / 2 * slopeForce * Time.deltaTime);
        }
        SetMovementSpeed();

        JumpInput();

    }

    private void SetMovementSpeed()
    {
        if (Input.GetKey(runKey))
            movementSpeed = Mathf.Lerp(movementSpeed, runSpeed, runBuildUpSpeed * Time.deltaTime);
        else
            movementSpeed = Mathf.Lerp(movementSpeed, walkSpeed, runBuildUpSpeed * Time.deltaTime);
    }

    private bool OnSlope()
    {
        if (isJumping)
            return false;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, controller.height / 2 * slopeForceRayLength))
            if (hit.normal != Vector3.up)
                return true;

        return false;
    }

    private void JumpInput()
    {

        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            isJumping = true;
            StartCoroutine(JumpEvent());
        }

    }

    private IEnumerator JumpEvent()
    {
        controller.slopeLimit = 90.0f;
        float timeInAir = 0.0f;
        do
        {
            float jumpForce = jumpFallOff.Evaluate(timeInAir);
            controller.Move(Vector3.up * jumpForce * jumpMultiplier * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        }
        while (!controller.isGrounded && controller.collisionFlags != CollisionFlags.Above);
        isJumping = false;
        controller.slopeLimit = 45.0f;

    }


}
