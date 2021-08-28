using UnityEngine;
public interface DoDamage
{
    void MakingDamage(int damage);
}
public class Weapon_base : MonoBehaviour
{
    public int damage;
    public DoDamage damageType;

    public void Attacking()
    {
        
    }
    
}
