using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public Spell[] possibleSpells;
    public SpellManager spellManager;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("spell"))
        {
            int otherid = other.gameObject.GetComponent<ids>().id;
            spellManager.spells.Add(possibleSpells[otherid]);
            Destroy(other.gameObject);
        }
    }
}
