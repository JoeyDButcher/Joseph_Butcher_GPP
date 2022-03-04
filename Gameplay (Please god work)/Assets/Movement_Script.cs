using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_Script : MonoBehaviour
{
    public CharacterController controller;
    public float player_speed = 5f;
    public float y_speed = 0.1f;
    Player_Controller controls;
    Vector2 movement;
    Animator player_animator;
    Vector3 jump_movement;
    public float jump_direction;
    bool JumpStatus = false;
    public float speed_timer = 5f;
    //public float jump_timer = 5f;

    bool speed_powerup = false;
    bool jump_powerup = false;


    void Awake()
    {
        controls = new Player_Controller();
        controls.Controller_Input.Movement.performed += context => movement = context.ReadValue<Vector2>();
        controls.Controller_Input.Movement.canceled += context => movement = Vector2.zero;

        controls.Controller_Input.Dodge.performed += context => player_animator.SetTrigger("DodgeTrigger"); 
        controls.Controller_Input.Jump.performed += context => Jump();
        controls.Controller_Input.Attack.performed += context => Attack();

        player_animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 player_direction = new Vector3(horizontal, 0f, vertical);

        if (player_direction.magnitude >= 0.5f)
        {
            controller.Move(player_direction * player_speed * Time.deltaTime);
            float Angle = Mathf.Atan2(player_direction.x, player_direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, Angle, 0f);

            player_animator.SetBool("IsRunning", true);
        }
        else
        {
            player_animator.SetBool("IsRunning", false);
        }

        if (speed_powerup == true)
        {
            Super_Speed();
        }

        if (controller.isGrounded)
        {
            JumpStatus = false;
        }

    }

    void OnEnable()
    {
        controls.Controller_Input.Enable();
    }

    void OnDisable()
    {
        controls.Controller_Input.Disable();
    }

    void Attack()
    {
        player_animator.SetTrigger("AttackTrigger");
    }

    void Jump()
    {
        if (JumpStatus == false)
        {
            player_animator.SetTrigger("JumpTrigger");
            y_speed = 2f;
            jump_direction = y_speed;

            jump_movement.y = jump_direction;
            controller.Move(jump_movement);
            if (jump_powerup == true)
            {
                player_animator.SetTrigger("JumpTrigger");
                y_speed = 2f;
                jump_direction = y_speed;

                jump_movement.y = jump_direction;
                controller.Move(jump_movement);
                jump_powerup = false;
            }
            else
            {
                JumpStatus = true;
            }
            
        }
    }

    void Super_Speed()
    {
        player_speed = 15f;
        speed_timer -= Time.deltaTime;
        if (speed_timer <= 0)
        {
            player_speed = 5f;
            speed_timer = 5f;
            speed_powerup = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Speed_Boost")
        {
            speed_powerup = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "Double_Jump")
        {
            jump_powerup = true;
            Destroy(other.gameObject);
        }
    }
}
