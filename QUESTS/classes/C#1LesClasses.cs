public class Character
{
    public string player; 
    public int PV;
    public int force;
    public int defense;
    
    public void IsAlive()
    {
        if (lifePoint == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    Character otherCharacter = new Character(); 
    public void Attack(otherCharacter)
    {
        attaque.PV = attaque.PV - (attaquant.force - attaque.defense);
    }
}

