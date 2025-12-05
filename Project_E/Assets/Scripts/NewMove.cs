using UnityEngine;
using UnityEngine.InputSystem;

public class NewMove : MonoBehaviour
{
    [SerializeField] float speed = 5f; //10진수
    private Vector2 moveInput;

    void Update()
    {
        Vector3 dir = new Vector3(moveInput.x, 0, moveInput.y); //매프레임마다
        transform.Translate(dir * speed * Time.deltaTime); //현실과 동일하게
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
