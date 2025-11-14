using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private float gameSpeed = 1;
    private float gameTime = 0;

    public float GameSpeed
    {
        get { return gameSpeed; }
        set { gameSpeed = Mathf.Max(0, value); } 
    }

    public float GameTime
    {
        get { return gameTime; }
    }

}
