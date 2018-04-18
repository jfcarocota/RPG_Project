using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.Character3D;
using GameUtils.AudioController;

public class Player : Character3D
{
    protected override void Attack()
    {
        base.Attack();

        if (AttackButton)
        {
            anim.SetTrigger("attack");
        }
    }

    protected override void Movement()
    {
        base.Movement();
        anim.SetFloat("move", Mathf.Abs(Axis.magnitude));

        transform.Translate(Vector3.forward * Axis.magnitude * speed * Time.deltaTime);

        if (Axis != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(Axis.x, 0f, Axis.y));
        }

        //Debug.Log(AudioController.AudioName(1));
        //Debug.Log(AudioMixSuperCoolXDjajaSaludos.Insultar);
    }
}
