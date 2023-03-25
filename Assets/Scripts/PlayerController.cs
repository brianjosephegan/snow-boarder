using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _torqueAmount = 1f;

    private Rigidbody2D _rbd2;

    // Start is called before the first frame update
    void Start()
    {
        _rbd2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rbd2.AddTorque(_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rbd2.AddTorque(-_torqueAmount);
        }
    }
}
