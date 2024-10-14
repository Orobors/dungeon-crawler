using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Spell", menuName = "Spell")]
public class Spell : ScriptableObject
{
    public string spellname;
    public int spellid;
    public int spellcost;
    public int spellrarity;
    public float spellcastcooldown;
    public int damage;
    [Header("Damage Over Time")]
    public int dps;
    public int seconds;
    [Header("Area Of Effect")]
    public float aoeradius;
    public bool aoepassive;
    public float aoetime;
    public AnimationCurve aoedamagefalloff;
}
