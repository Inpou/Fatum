using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 _movementVector;
    private Animator _animator;
    public JoyStickController JoyStickController;
    private Rigidbody2D _rigidBody;
    public float Speed = 3f;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        float h = JoyStickController.Horizontal();
        float v = JoyStickController.Vertical();
        Speed = Input.GetKey(KeyCode.LeftShift)?5f:3f;
        Move(h, v);
        PlayAnimation(h, v);
    }

    void Move(float h, float v)
    {
        _movementVector.Set(h, v, 0f);
        _movementVector = _movementVector.normalized * Speed * Time.deltaTime;
        _rigidBody.MovePosition(transform.position + _movementVector);
    }
    void PlayAnimation(float h, float v)
    {
       _animator.SetBool("IsWalkingTop", v > 0);
       _animator.SetBool("IsWalkingBot", v < 0);
       _animator.SetBool("IsWalkingLeft", h < 0);
       _animator.SetBool("IsWalking", h > 0);
       
    }
//    void SwitchAnimation(WalkAnimationTool.WalkDirections animation, bool offAnimation = false)
//    {
//        string animationToOn = animation.Get();
//        string animationToOff = animation.GetOpposite();
//        _animator.SetBool(animationToOn, !offAnimation);
//        _animator.SetBool(animationToOff, false);
//    }
//    void VerticalAnimation(float v)
//    {
//        SwitchAnimation(v > 0 ? WalkAnimationTool.WalkDirections.Top : WalkAnimationTool.WalkDirections.Bottom, v == 0);
//    }
//    void HorizontalAnimation(float h)
//    {
//        SwitchAnimation(h > 0 ? WalkAnimationTool.WalkDirections.Right : WalkAnimationTool.WalkDirections.Left, h == 0);
//    }
//    void PlayAnimation(float h, float v)
//    {
//        HorizontalAnimation(h);
//        VerticalAnimation(v);
//    }
}