using UnityEngine;

namespace Hmxs.Scripts.Protagonist
{
    public class SnowSceneProtagonistController : MonoBehaviour
    {
        public float speed;
        public float windIntensity;

        private float _movementInput;

        private Rigidbody2D  _rigidbody;
        private Animator _animator;

        private static readonly int IsWalking = Animator.StringToHash("IsWalking");

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            InputHandler();
            UpdateAnimState();
        }

        private void FixedUpdate()
        {
            ApplyMovement();
        }

        private void InputHandler()
        {
            _movementInput = Input.GetAxis("Horizontal");
        }

        private void ApplyMovement()
        {
            _rigidbody.velocity = new Vector2(_movementInput * speed - windIntensity, _rigidbody.velocity.y);
        }

        private void UpdateAnimState()
        {
            _animator.SetBool(IsWalking, Mathf.Abs(_rigidbody.velocity.x) > 0.01);
        }
    }
}