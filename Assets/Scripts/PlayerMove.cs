using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    public LayerMask ground;
    public Transform PlayerCam;
    private Transform cam;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cam = Camera.main.transform;
    }

    void Update()
    {
        //Solta um raycast pra baixo da posi��o do jogador para saber se est� no ch�o
        if (Physics.Raycast(PlayerCam.position, Vector3.down, 0.3f, ground)) groundedPlayer = true;
        else groundedPlayer = false;

        // Caso esteja no ch�o o jogador para de cair
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        //Coloca em uma variavel o WASD e as setas do player
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Muda o vetor dependendo da posi��o da camera do jogador assim pode controlar facilmente
        move = cam.forward * move.z + cam.right * move.x;
        move.y = 0f;

        //Move o jogador de acordo com o vetor
        controller.Move(move * Time.deltaTime * playerSpeed);

        //Muda a altura do jogador ao apertar espa�o
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        //Gravidade
        playerVelocity.y += gravityValue * Time.deltaTime;
        //Velocidade
        controller.Move(playerVelocity * Time.deltaTime);
    }
}