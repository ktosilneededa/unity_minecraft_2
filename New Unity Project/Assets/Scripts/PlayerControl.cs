using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour, InputActions.IPlayerControlActions
{
    private Vector3 moveDirection;

    private InputActions actions;
    private PlayerInput playerInput;

    public Transform cameraTargetTransform;
    public GameObject[] Voxels;
    public int voxelType;

    private Rigidbody rigidbody;
    private Animator anim;

    public float Speed = 10f;
    public float Jump = 300f;

    private void OnEnable()
    {
        if (actions == null)
        {
            actions = new InputActions();
            actions.PlayerControl.SetCallbacks(this);
        }
        actions.PlayerControl.Enable();
    }

    private void OnDisable()
    {
        actions.PlayerControl.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {   var offset = context.ReadValue<Vector2>();
        moveDirection = new Vector3(offset.x, 0, -offset.y);
        anim.SetInteger("Walk", 1);
        if (Keyboard.current.wKey.wasReleasedThisFrame || Keyboard.current.aKey.wasReleasedThisFrame
            || Keyboard.current.sKey.wasReleasedThisFrame || Keyboard.current.dKey.wasReleasedThisFrame)
        {
            anim.SetInteger("Walk", 0);
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        var offset = context.ReadValue<Vector2>();
        var playerEulerAngle = transform.rotation.eulerAngles + new Vector3(0, offset.x, 0) * 0.1f;
        transform.rotation = Quaternion.Euler(playerEulerAngle);
        var cameraEulerAngle = cameraTargetTransform.rotation.eulerAngles + new Vector3(-offset.y, 0, 0) * 0.1f;
        cameraTargetTransform.rotation = Quaternion.Euler(cameraEulerAngle);
    }

    void Start() 
    {
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        var v = Camera.main.cameraToWorldMatrix.MultiplyVector(moveDirection * Speed);
        rigidbody.velocity = new Vector3(v.x, rigidbody.velocity.y, v.z);
        rigidbody.angularVelocity = Vector3.zero;
    }

    void NewVoxel(int voxeltype, Vector3 position)
    {
        var newVoxel = Instantiate(Voxels[voxeltype], position, Quaternion.identity);
    }

    public void OnSetVoxel(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.collider != null) 
                {
                    var fo = hit.collider.tag;
                    if (fo == "Voxel")
                    {
                        Vector3 position = hit.collider.transform.position + hit.normal;
                        NewVoxel(voxelType, position);
                    }
                }
            }
        }
    }

    public void OnRemoveVoxel(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.collider != null)
                {
                    var fo = hit.collider.tag;
                    if (fo == "Voxel")
                    {
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {

            rigidbody.AddForce(Vector3.up * Jump);
            //rigidbody.velocity = transform.up * Jump;
           //transform.Translate(Vector3.up * Time.deltaTime * Jump, Space.World);
            anim.SetTrigger("jump");
        }
    }
}
