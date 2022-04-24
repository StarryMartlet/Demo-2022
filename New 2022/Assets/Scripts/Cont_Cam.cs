using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont_Cam : MonoBehaviour
{
    [SerializeField] private Transform heroj;

    private void Update()
    {
        transform.position = new Vector3(heroj.position.x, heroj.position.y, transform.position.z);
    }
}
