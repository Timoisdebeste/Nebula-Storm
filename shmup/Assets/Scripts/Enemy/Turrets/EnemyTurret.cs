using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{ 
    
}
//{
    //[SerializeField] private UnityTargetableEvent onTargetFound = new UnityTargetableEvent();
    //[SerializeField] private UnityEvent ontargetLost = new UnityEvent();

    //public TargetebleBehaviour CurrentTarget { get; private set; }

    //public bool HasTarget => CurrentTarget != null;

    //private void OnTriggerEnter(Collider other)
    //{
        //if (HasTarget) { return; }

        //if (!other.TryGetComponent(out TargetebleBehaviour target))
        //{
            //return;
        //}

        //CurrentTarget = target;

        //onTargetFound.Invoke(CurrentTarget);
    //}


//}
//{
    //public Transform player;
    //public float moveSpeed = 5f;
    //private Rigidbody2D rb;


    //public GameObject playerC;

    //public GameObject where;
    //public GameObject playerB;
    //public GameObject bulletPrefab;
    //public GameObject bulletStart;

    //public float bulletSpeed = 20.0f;

    //private Vector3 target;


    // Start is called before the first frame update
    //void Start()
    //{
        //rb = this.GetComponent<Rigidbody2D>();
    //}

    // Update is called once per frame
    //void Update()
    //{
        //Vector3 direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        //direction.Normalize();


        //target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        //where.transform.position = new Vector2(target.x, target.y);

        //Vector3 difference = direction - playerB.transform.position;
        //float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //playerB.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        //if (Input.GetMouseButtonDown(0))
        //{
            //float distance = difference.magnitude;
            //Vector2 directionb = difference / distance;
            //direction.Normalize();
            //FireBullet(direction, rotationZ);
        //}
    //}
    //void FireBullet(Vector2 direction, float rotationZ)
    //{
        //GameObject b = Instantiate(bulletPrefab) as GameObject;
        //b.transform.position = bulletStart.transform.position;
        //b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        //b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    //}
//}