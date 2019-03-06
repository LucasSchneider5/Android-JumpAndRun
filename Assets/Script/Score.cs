using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform Charakter;
    public Text scoreText;
	void Update () {
        scoreText.text = Charakter.position.x.ToString("0");
	}
}
