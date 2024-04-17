using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] Playercontroller player;
    [SerializeField] Image foreground;

    private void Update()
    {
        if (player != null)
        {
            float hpRatio = (float)player.PlayerHp / player.maxplayerHP;
            foreground.transform.localScale = new Vector3(hpRatio, 1, 1);
        }
    }
}
