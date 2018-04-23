using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.Character3D;
using GameUtils.AudioController;
using GameUtils.GameInputs;

public class Player : Character3D
{

    [SerializeField]
    GameObject srcSkillShot;

    [SerializeField]
    Transform skillShotPoint;

    IEnumerator createSkillShot;

    private void Start()
    {
        GameManager.instance.Player = this;
    }

    protected override void Attack()
    {
        base.Attack();

        if (GameInputs.AttackButton)
        {
            createSkillShot = SkillShotCorutine();
            anim.SetTrigger("attack");
        }
    }

    public void CreateSkillShot()
    {
        StartCoroutine(createSkillShot);
    }

    IEnumerator SkillShotCorutine()
    {
        yield return new WaitForSeconds(0.10f);
        Instantiate(srcSkillShot, skillShotPoint.position, transform.rotation);
    }

    protected override void Movement()
    {
        base.Movement();
        anim.SetFloat("move", Mathf.Abs(GameInputs.Axis.magnitude));

        transform.Translate(Vector3.forward * GameInputs.Axis.magnitude * speed * Time.deltaTime * multiplierSpeed);

        if (GameInputs.Axis != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(GameInputs.Axis.x, 0f, GameInputs.Axis.y));
        }

        //Debug.Log(AudioController.AudioName(1));
        //Debug.Log(AudioMixSuperCoolXDjajaSaludos.Insultar);
    }
}
