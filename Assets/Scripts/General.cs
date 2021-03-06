using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public enum SceneName
    {
        MainMenu,
        Game,
        End
    }
    private static int bodyNameCount = 9;
    public static int GetBodyNameCount() => bodyNameCount;
    public enum BodyNames : int
    {
        Sun,
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    public enum ButtonEventColors
    {
        Idle,
        Hovered,
        Pressed,
        Released
    }
}
