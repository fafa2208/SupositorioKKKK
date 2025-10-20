using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private InputSystem_Actions Input;

    private Vector2 moveInput => Input.Player.Move.ReadValue<Vector2>();

    [SerializeField] private float movespeed;
    private void Awake()
    {
        Input = new InputSystem_Actions();
        Input.Player.Enable();
    }

    private void Update()
    {
        transform.Translate(moveInput.x * movespeed * Time.deltaTime, 0,0);
    }
}
