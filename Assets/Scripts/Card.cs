using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Start is called before the first frame update   
    public enum classEnemy
    {
        orc,
        human,
        undead,
        neutral
    }
    [System.Serializable]
    public class Enemy
    {
        public string EnemyName;

        [TextArea(1,3)]
        public string EnemyDes;
        public Sprite EnemySprite;
        public classEnemy EnemyClass;

        public int EID;
        public bool infoTaken= false;
    }

    public class TypeChart
    {
        static float[][] chart = 
        {
            new float[] {1f, 1f, 1f, 1f}, //orc
            new float[] {1f, 1f, 1f, 1f}, //human
            new float[] {1f, 1f, 1f, 1f}, //undead
            new float[] {1f, 1f, 1f, 1f} //neutral
        };
    }