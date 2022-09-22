using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreColider : MonoBehaviour
{
    private void Start()
    {
        print("Aqui");
        Physics.IgnoreLayerCollision(8,9);
    }

}

