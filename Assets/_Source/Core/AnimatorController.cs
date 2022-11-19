using UnityEngine;

namespace RouteTeamStudio.Core
{
    public abstract class AnimatorController : Controller
    {
        protected Animator _animator;

        protected float _animationLocked;
        protected int _currentAnimation;
        protected int _animationAsked;

        public abstract void ChangeAnimation(int animation);

        public override void OnAwake()
        {
            _animator = gameObject.GetComponentInChildren<Animator>();
        }

        public override void OnUpdate()
        {
            ChangeAnimation(-1);

            if (_currentAnimation != _animationAsked)
            {
                _animator.CrossFade(_animationAsked, 0, 0);
                _currentAnimation = _animationAsked;
            }
        }

        protected int LockAnimation(int animation, float lockTime)
        {
            _animationLocked = Time.time + lockTime;
            return animation;
        }
    }
}