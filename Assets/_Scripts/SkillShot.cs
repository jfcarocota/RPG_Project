using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillShot : MonoBehaviour
{
    [SerializeField]
    GameObject orbHit;

    [SerializeField]
    float moveSpeed;

    [SerializeField]
    float delay;

    IEnumerator move;

    private void OnEnable()
    {
        move = Move(delay);
        StartCoroutine(move);
    }

    IEnumerator Move(float delay)
    {
        while (!orbHit.activeSelf)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            yield return new WaitForSeconds(delay);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        orbHit.SetActive(other.CompareTag("hit"));
        if (orbHit.activeSelf)
        {
            ParticleSystem ps = orbHit.GetComponent<ParticleSystem>();
            Destroy(gameObject, ps.startLifetime);
        }
    }
}
