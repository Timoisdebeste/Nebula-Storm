using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootSuper : MonoBehaviour
{
    public Transform projectileSpawn;

    public GameObject projectile;

    float nextFire = 0.0f;
    [SerializeField] float currentTime = 15f;

    [SerializeField] Text SuperCountdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 15.0f;
        projectileSpawn = this.gameObject.transform;

        SuperCountdownText.text = "20";
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();

        SuperCountdownText.text = currentTime.ToString ("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }

    public void Shoot()
    {
        currentTime -= Time.deltaTime;

        if (Input.GetButton("Fire1") && currentTime <= nextFire)
        {
            nextFire -= currentTime;

            Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //shoot! create the object

            currentTime = 15.0f;
        }
    }
}
