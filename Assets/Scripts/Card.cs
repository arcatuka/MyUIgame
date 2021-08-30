using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Start is called before the first frame update   
    public enum classEnemy
    {
        none,
        orc,
        human,
        undead,
        elf
    }
    [CreateAssetMenu(fileName ="NewUnit", menuName ="Create new Unit")]
    public class Card : ScriptableObject
    {
        [SerializeField] string EnemyName;

        [TextArea(1,3)]
        [SerializeField] string EnemyDes;
        [SerializeField] Sprite EnemySprite;
        [SerializeField] classEnemy EnemyClass;

        [SerializeField] int EID;
        [SerializeField] bool infoTaken= false;
        [SerializeField] int Enemyattack;
        [SerializeField] int Enemydefense;

    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }
    public string EnemyDes1 { get => EnemyDes; set => EnemyDes = value; }
    public Sprite EnemySprite1 { get => EnemySprite; set => EnemySprite = value; }
    public classEnemy EnemyClass1 { get => EnemyClass; set => EnemyClass = value; }
    public int Enemyattack1 { get => Enemyattack; set => Enemyattack = value; }
    public int Enemydefense1 { get => Enemydefense; set => Enemydefense = value; }
    public bool InfoTaken { get => infoTaken; set => infoTaken = value; }

    public class TypeChart
    {
        static float[][] chart =
        {
            new float[] {1f, 2f,   0.5f, 0.5f}, //orc
            new float[] {2f, 1f,   2f,   1f}, //human
            new float[] {2f, 0.5f, 1f,   2f}, //undead
            new float[] {2f, 0.5f, 0.5f, 1f} //elf
        };
        public static float Getffectiveness(classEnemy attacker ,  classEnemy defender)
        {
            if (attacker == classEnemy.none || defender == classEnemy.none)
            {
                return 1;
            }
            int row = (int)attacker -1;
            int col = (int)defender -1;

            return chart[row][col];

        }
    }
}
