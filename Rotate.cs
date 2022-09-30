
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;


public class Rotate : MonoBehaviour 

{

    [SerializeField] private float speed = 50f;

    private void Update()
    {
        this.transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * speed);
    }




}