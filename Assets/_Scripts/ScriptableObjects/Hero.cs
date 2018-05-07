using UnityEngine;
using GameUtils.CharacterStatsSystem;

[CreateAssetMenu(fileName = "Hero", menuName = "Character/Hero", order = 1)]
public class Hero : CharacterStats
{
    [SerializeField]
    Vector3 position;
    [SerializeField]
    float currentExperience;
    [SerializeField]
    float experienceToNextLevel;
    [SerializeField]
    string lore;
    [SerializeField]
    Sprite heroSprite;

    public Vector3 Position
    {
        get
        {
            return position;
        }

        set
        {
            position = value;
        }
    }

    public float CurrentExperience
    {
        get
        {
            return currentExperience;
        }

        set
        {
            currentExperience = value;
        }
    }

    public float ExperienceToNextLevel
    {
        get
        {
            return experienceToNextLevel;
        }

        set
        {
            experienceToNextLevel = value;
        }
    }

    public string Lore
    {
        get
        {
            return lore;
        }

        set
        {
            lore = value;
        }
    }

    public Sprite HeroSprite
    {
        get
        {
            return heroSprite;
        }

        set
        {
            heroSprite = value;
        }
    }
}
