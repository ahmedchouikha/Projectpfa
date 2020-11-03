
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform Player;
    public Text scoretxt;
    // Update is called once per frame
    void Update()
    {
        scoretxt.text = Player.position.z.ToString("0");
    }
}
