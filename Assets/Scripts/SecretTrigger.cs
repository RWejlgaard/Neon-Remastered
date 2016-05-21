using UnityEngine;
using System.Collections;

public class SecretTrigger : MonoBehaviour {

    public GameObject Secret;

    void OnTriggerEnter2D(Collider2D other) {
        Secret.SetActive(true);
    }
}
