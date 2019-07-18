using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WenZiKongZhi : MonoBehaviour
{
    public Text wenzitext;
    private string str = "仰望星空，浩瀚的宇宙苍穹给人以无限遐想，千百年来，人类一直向往能插上翅膀飞出地球，探索宇宙的奥秘。世界上第一颗人造卫星的发射，揭开了人类探索宇宙的新篇章。目前地球上空有这么多卫星，它们是怎样被发射升空的？点击地球开启卫星飞行探索之旅！";
    string s = "";
   
    private void Start()
    {
      
        Playtext();
    }
    private void Playtext()
    {
        StartCoroutine(Showtext(str.Length));
    }
   
    IEnumerator Showtext(int strlenght)
    {
        int i = 0;
        while (i < strlenght)
        {
            yield return new WaitForSeconds(0.08f);
            s += str[i].ToString();
            wenzitext.text = s;
            i += 1;
        }
        StopAllCoroutines();
    }
}


