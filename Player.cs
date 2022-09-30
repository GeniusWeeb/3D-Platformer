using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;


namespace Platformer
{
    public class Player : MonoBehaviour
    {
        private void Update()
        {
            this.transform.LookAt(Vector3.forward);
        }

    }

}
