using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MickolPaige
{
    public class FaceTowards : MonoBehaviour
    {
        public Transform ObjectToLookAt;

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(ObjectToLookAt);
        }
    }
}
