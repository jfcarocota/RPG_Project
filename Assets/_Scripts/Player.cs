using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.Character3D;
using GameUtils.AudioController;
using GameUtils.GameInputs;
using GameUtils.DataSystem;

public class Player : Character3D
{

    [SerializeField]
    AudioController audioController;

    [SerializeField]
    GameObject srcSkillShot;

    [SerializeField]
    Transform skillShotPoint;

    IEnumerator createSkillShot;

    bool attacking = false;

    new void Awake()
    {
        base.Awake();
        audioController.Aud = GetComponent<AudioSource>();
    }

    public bool Attacking
    {
        get
        {
            return attacking;
        }

        set
        {
            attacking = value;
        }
    }

    public AudioController AudController
    {
        get
        {
            return audioController;
        }
    }

    private void Start()
    {
        GameManager.instance.Player = this;
        AlterStats();
        DataSystem.SaveData(GameManager.instance.GameData);
    }

    protected override void Attack()
    {
        base.Attack();

        if (GameInputs.AttackButton && !attacking)
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

        if (GameInputs.Axis != Vector2.zero && !attacking)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(GameInputs.Axis.x, 0f, GameInputs.Axis.y));
        }

        //Debug.Log(AudioController.AudioName(1));
        //Debug.Log(AudioMixSuperCoolXDjajaSaludos.Insultar);
    }

    public void WalkingSFX()
    {
        if (!audioController.Playing)
        {
            audioController.PlayClip(0);
        }
    }

    public void AlterStats()
    {
        GameManager.instance.GameData = new GameData(1, 0, 0, 10, 4, 3);
    }
}
