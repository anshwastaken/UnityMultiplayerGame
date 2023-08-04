using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


public class NETWORKMOVEMENT : NetworkBehaviour
{
    private void Update()
    {
        if (!IsOwner) return;

        Vector3 mov = new Vector3(0, 0,0);

        if (Input.GetKeyDown(KeyCode.W)) mov.z = +1f;
        if (Input.GetKeyDown(KeyCode.S)) mov.z = -1f;
        if (Input.GetKeyDown(KeyCode.A)) mov.x = -1f;
        if (Input.GetKeyDown(KeyCode.D)) mov.x = +1f;

        float movespeed = 10f;
        transform.position += mov * movespeed * Time.deltaTime;

    }
}
