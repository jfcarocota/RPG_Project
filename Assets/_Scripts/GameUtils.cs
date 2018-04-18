using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    namespace GameInputs
    {
        public static class GameInputs
        {
            public static Vector2 Axis
            {
                get { return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); }
            }

            public static bool AttackButton
            {
                get { return Input.GetButtonDown("Fire1"); }
            }
        }
    }

    namespace Character3D
    {
        [RequireComponent(typeof(Animator))]

        public abstract class Character3D : MonoBehaviour
        {
            [SerializeField]
            protected float speed;

            [SerializeField]
            protected float multiplierSpeed = 1f;

            protected Animator anim;

            public float MultiplierSpeed
            {
                get
                {
                    return multiplierSpeed;
                }

                set
                {
                    multiplierSpeed = value;
                }
            }

            private void Awake()
            {
                anim = GetComponent<Animator>();
            }

            private void Update()
            {
                Movement();
                Attack();
            }

            protected virtual void Movement()
            {

            }

            protected virtual void Attack()
            {

            }
        }
    }
}
