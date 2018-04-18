using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    namespace Character3D
    {
        [RequireComponent(typeof(Animator))]

        public abstract class Character3D : MonoBehaviour
        {
            [SerializeField]
            protected float speed;

            protected Animator anim;

            private void Awake()
            {
                anim = GetComponent<Animator>();
            }

            protected Vector2 Axis
            {
                get { return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); }
            }

            protected bool AttackButton
            {
                get { return Input.GetButtonDown("Fire1"); }
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
