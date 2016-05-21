using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//using UnityEditor;

public class PlayerClass : MonoBehaviour {
    public float WalkSpeed = 6.0f;
    public float RotationSpeed = 4.0f;

    void Start() {
    }

    void Update() {

        transform.Rotate(0,0,-Input.GetAxis("Mouse X") * RotationSpeed);

        Vector3 _dir = new Vector3();
        if (Input.GetKey(KeyCode.W)) {
            _dir.y += 1f;
        }
        else if (Input.GetKey(KeyCode.A)) {
            _dir.x -= 1f;
        }
        else if (Input.GetKey(KeyCode.S)) {
            _dir.y -= 1f;
        }
        else if (Input.GetKey(KeyCode.D)) {
            _dir.x += 1f;
        }
        else {
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
        _dir.Normalize();
        transform.Translate(_dir*Time.deltaTime*WalkSpeed);
    }
}