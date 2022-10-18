using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooting : MonoBehaviour
{
    [SerializeField] private Transform _cannon = null;
    [SerializeField] private float _maxRange = 10f;
    [Header("Shooting Settings")]
    [SerializeField] private int _damage = 10;
    [SerializeField] private AudioSource audioSource = null;
    [SerializeField] private GameObject _impactEffect = null;


    private void FixedUpdate()
    {
        var ray = new Ray(origin: _cannon.position, direction:_cannon.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out var hit, _maxRange))
        {
            if(hit.collider.CompareTag("Enemy"))
            {
                if (!_audioSource.isPlaying)
                    _audioSource.Play();

                hit.collider.GetComponent<Health>().RecieveDamage(_damage);
            }
        }
    }
       

}
