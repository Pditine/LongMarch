using System;
using Hmxs.Toolkit.Module.Audios;
using UnityEngine;
using AudioType = Hmxs.Toolkit.Module.Audios.AudioType;

namespace Hmxs.Scripts.Protagonist
{
    public class ProtagonistController : Pditine.Scripts.Tool.MonoSingleton<ProtagonistController>
    {
        public GameObject interactInfo;
        public float speed;

        private float _movementInput;
        private bool _isFacingRight = true;

        private Rigidbody2D  _rigidbody;
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;

        private static readonly int IsWalking = Animator.StringToHash("IsWalking");

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            InputHandler();
            CheckFlip();
            UpdateAnimState();
            // if(Mathf.Abs(_rigidbody.velocity.x)>=0.01f)
            //     AudioCenter.Instance.AudioPlaySync(new AudioAsset(AudioType.Effect,"草地上行走"));
        }

        private void FixedUpdate()
        {
            ApplyMovement();
        }

        private void InputHandler()
        {
            _movementInput = Input.GetAxis("Horizontal");
        }

        private void CheckFlip()
        {
            if ((_isFacingRight && _rigidbody.velocity.x < -0.01f) ||
                (!_isFacingRight && _rigidbody.velocity.x > 0.01f))
                Flip();
        }

        private void Flip()
        {
            _isFacingRight = !_isFacingRight;
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }

        private void ApplyMovement()
        {
            _rigidbody.velocity = new Vector2(_movementInput * speed, _rigidbody.velocity.y);
        }

        private void UpdateAnimState()
        {
            _animator.SetBool(IsWalking, Mathf.Abs(_rigidbody.velocity.x) > 0.01);
        }

        public void ShowInteractInfo()
        {
            interactInfo.SetActive(true);
        }

        public void HideInteractInfo()
        {
            interactInfo.SetActive(false);
        }
        
        // private void OnTriggerEnter2D(Collider2D other)
        // {
        //     if (other.CompareTag("InteractableItem"))
        //         interactInfo.SetActive(true);
        // }
        //
        // private void OnTriggerExit2D(Collider2D other)
        // {
        //     if (other.CompareTag("InteractableItem"))
        //         interactInfo.SetActive(false);
        // }
    }
}