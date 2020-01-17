//
// DO NOT MODIFY THIS FILE.
//
// This file is automatically generated using the behavior_tree_translator.py script
// on the file: ../../Assets/Behavior Tree Definitions\bt_tutorial_sprint.xml
//

using BattleTech;


public static class TutorialSprint_BT
{
    public static BehaviorNode InitRootNode(BehaviorTree behaviorTree, AbstractActor unit, GameInstance game)
    {
        IsAttackAvailableForUnitNode attackAvailable0000 = new IsAttackAvailableForUnitNode("attackAvailable0000", behaviorTree, unit);

        FindPlayerTutorialTargetNode findPlayerTutorialTarget0000 = new FindPlayerTutorialTargetNode("findPlayerTutorialTarget0000", behaviorTree, unit);

        ShootTrainingWeaponsAtTargetNode shootTrainingWeaponsAtTarget0000 = new ShootTrainingWeaponsAtTargetNode("shootTrainingWeaponsAtTarget0000", behaviorTree, unit);

        SequenceNode attack_sequence = new SequenceNode("attack_sequence", behaviorTree, unit);
        attack_sequence.AddChild(attackAvailable0000);
        attack_sequence.AddChild(findPlayerTutorialTarget0000);
        attack_sequence.AddChild(shootTrainingWeaponsAtTarget0000);

        BraceNode brace0000 = new BraceNode("brace0000", behaviorTree, unit);

        SelectorNode selector0000 = new SelectorNode("selector0000", behaviorTree, unit);
        selector0000.AddChild(attack_sequence);
        selector0000.AddChild(brace0000);

        return selector0000;
    }
}