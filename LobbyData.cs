using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyData : MonoBehaviour {
    [HideInInspector]
    public static LobbyData instance;
    void Awake() {
        if (instance == null)
            instance = this;
        else {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public int numOfConnectedPlayer=0;

}
