using System.Collections;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    IEnumerator Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        WaitForSeconds wait = new WaitForSeconds(3);

        while (true) 
        {
            yield return wait;
            float force = Random.Range(7, 10) * body.mass;

            body.AddForce(transform.up * force, ForceMode.Impulse);
        }
    }

}
