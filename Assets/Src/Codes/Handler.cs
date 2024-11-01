using UnityEngine;
using System;


public class Handler
{
    public static void InitialHandler(InitialResponse res)
    {
        try
        {
            GameManager.instance.GameStart();
            GameManager.instance.player.SetPosition(res.x, res.y);
        }
        catch (Exception e)
        {
            Debug.LogError(e);
        }
    }
}
