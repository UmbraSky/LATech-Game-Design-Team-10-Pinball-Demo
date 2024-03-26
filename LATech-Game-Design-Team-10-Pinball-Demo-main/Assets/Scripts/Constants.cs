using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public static class Tags {
        public const string RESTART = "Restart";
        public const string DEATH = "Death";
        public const string SCORECIRCLE = "ScoreCircle";
    }
    public static class PlayerPrefs {
        public const string RECORDSCORE = "RecordScore";
    }
    public static class Points {
        public const int BUMP = 500;
        public const int PRESS = 300;
        public const int UNLOCK = 5000;
        public const int UPDATE = 0;
    }
}