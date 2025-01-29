using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text vidatexto;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUIVida();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUIVida();
    }

    private void UpdateUIVida()
    {
        if(player != null)
        {
            vidatexto.text = player.GetCurrentHealth().ToString();
        }
        else
        {
            vidatexto.text = "0";
        }
    }
}
