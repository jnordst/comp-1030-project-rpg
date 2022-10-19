using System.Collections;
using System.Collections.Generic;

namespace project_rpg;
class Program
{
    List<Battler> Battlers = new List<Battler>(); // All battlers in battle

    // Declare Party Members
    List<Party_Member> Party_Members = new List<Party_Member>();
    Party_Member Hero;
    Party_Member Priest;

    // Declare Enemies
    List<Enemy> Enemies = new List<Enemy>();
    Enemy Slime;
    Enemy Goblin;

    void Start()
    {
        SetupPartyMembers();
        SetupEnemies();
        SelectPartyMembers();
        Battle();
    }

    void SetupPartyMembers()
    {
        // Setup Each Party Members Stats
        // Make abstract class and setup in another file?
        Hero.name = "Hero";
        Hero.maxHP = 50;
        Hero.hp = 50;
        Hero.maxMP = 10;
        Hero.mp = 10;
        Hero.atk = 15;
        Hero.spd = 8;
        // and so on...
    }

    void SetupEnemies()
    {
        // Setup Each Enemy Stats
        // Make abstract class and setup in another file?
        Slime.name = "Slime";
        Slime.maxHP = 20;
        Slime.hp = 20;
        Slime.atk = 8;
        Slime.spd = 4;
        // and so on...
    }

    void SelectPartyMembers()
    {
        // List 5~ Party Members. Player is prompted to select 1
        // After selecting, the Party Member will be removed from the List and prompted again to select 1 more
        // After selecting, the Party Member will be removed from the List and prompted again to select 1 more
        // The 3 characters will be added to PartyMembers list
    }

    void Battle()
    {
        // Automatically select 1-3 random Enemies
        // Turn Order is decided by every Battlers speed stat
        // On player turn you can choose 1 or 2
        // 1: Attack
        // 2: Skill
        // Once an enemy or party member is defeated it will be removed from Turn Order
        // Once all enemies are defeated the battle is won and player can decide if they want to continue or quit
        // Once all party members are defeated the battle is lost and the player can decide if they want to restart or quit
        // Selecting continue will pick another 1-3 random enemies and fully heal your party members
    }
}