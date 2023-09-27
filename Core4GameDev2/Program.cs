// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Attack Punch = new("Punch", 20);
// Attack Kick = new("Kick", 15);
// Attack Tackle = new("Tackle", 25);

Melee testMan = new("Melee fighter");

// testMan.RandomAttack();

Ranged Archer = new("Bow man");

Caster Wizard = new("Gandalf");

testMan.PerformAttack(Archer, testMan.AttackList[1]);
testMan.Rage(Wizard);
Archer.PerformAttack(testMan, Archer.AttackList[0]);
Archer.Dash();

Archer.PerformAttack(testMan, Archer.AttackList[0]);
Wizard.Heal(Archer);
Wizard.PerformAttack(testMan, Wizard.AttackList[0]);