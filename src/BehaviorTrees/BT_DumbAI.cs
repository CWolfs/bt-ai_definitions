//
// DO NOT MODIFY THIS FILE.
//
// This file is automatically generated using the behavior_tree_translator.py script
// on the file: ../../Assets/Behavior Tree Definitions\bt_dumb_ai.xml
//

using BattleTech;


public static class DumbAI_BT
{
    public static BehaviorNode InitRootNode(BehaviorTree behaviorTree, AbstractActor unit, GameInstance game)
    {
        LanceHasLOSNode lanceHasLOS0000 = new LanceHasLOSNode("lanceHasLOS0000", behaviorTree, unit);

        FindVisibleEnemiesNode findVisibleEnemies0000 = new FindVisibleEnemiesNode("findVisibleEnemies0000", behaviorTree, unit);

        IsMovementAvailableForUnitNode movementAvailable0000 = new IsMovementAvailableForUnitNode("movementAvailable0000", behaviorTree, unit);

        SortEnemiesByThreatNode sortEnemiesByThreat0000 = new SortEnemiesByThreatNode("sortEnemiesByThreat0000", behaviorTree, unit);

        MoveTowardsHighestPriorityEnemyNode moveTowardsHighestPriorityEnemy0000 = new MoveTowardsHighestPriorityEnemyNode("moveTowardsHighestPriorityEnemy0000", behaviorTree, unit);

        SequenceNode canMove = new SequenceNode("canMove", behaviorTree, unit);
        canMove.AddChild(movementAvailable0000);
        canMove.AddChild(sortEnemiesByThreat0000);
        canMove.AddChild(moveTowardsHighestPriorityEnemy0000);

        IsAttackAvailableForUnitNode attackAvailable0000 = new IsAttackAvailableForUnitNode("attackAvailable0000", behaviorTree, unit);

        SortEnemiesByEffectivenessNode sortEnemiesByEffectiveness0000 = new SortEnemiesByEffectivenessNode("sortEnemiesByEffectiveness0000", behaviorTree, unit);

        ShootAtHighestPriorityEnemyNode shootAtHighestPriorityEnemy0000 = new ShootAtHighestPriorityEnemyNode("shootAtHighestPriorityEnemy0000", behaviorTree, unit);

        SequenceNode canAttack = new SequenceNode("canAttack", behaviorTree, unit);
        canAttack.AddChild(attackAvailable0000);
        canAttack.AddChild(sortEnemiesByEffectiveness0000);
        canAttack.AddChild(shootAtHighestPriorityEnemy0000);

        SelectorNode selector0000 = new SelectorNode("selector0000", behaviorTree, unit);
        selector0000.AddChild(canMove);
        selector0000.AddChild(canAttack);

        SequenceNode free_engage = new SequenceNode("free_engage", behaviorTree, unit);
        free_engage.AddChild(lanceHasLOS0000);
        free_engage.AddChild(findVisibleEnemies0000);
        free_engage.AddChild(selector0000);

        IsMovementAvailableForUnitNode movementAvailable0001 = new IsMovementAvailableForUnitNode("movementAvailable0001", behaviorTree, unit);

        FindPreviouslySeenEnemiesNode findPreviouslySeenEnemies0000 = new FindPreviouslySeenEnemiesNode("findPreviouslySeenEnemies0000", behaviorTree, unit);

        SortEnemiesByProximityNode sortEnemiesByProximity0000 = new SortEnemiesByProximityNode("sortEnemiesByProximity0000", behaviorTree, unit);

        MoveTowardsHighestPriorityEnemyNode moveTowardsHighestPriorityEnemy0001 = new MoveTowardsHighestPriorityEnemyNode("moveTowardsHighestPriorityEnemy0001", behaviorTree, unit);

        SequenceNode hunt_previously_seen = new SequenceNode("hunt_previously_seen", behaviorTree, unit);
        hunt_previously_seen.AddChild(movementAvailable0001);
        hunt_previously_seen.AddChild(findPreviouslySeenEnemies0000);
        hunt_previously_seen.AddChild(sortEnemiesByProximity0000);
        hunt_previously_seen.AddChild(moveTowardsHighestPriorityEnemy0001);

        SelectorNode selector0001 = new SelectorNode("selector0001", behaviorTree, unit);
        selector0001.AddChild(hunt_previously_seen);

        FailNode fail0000 = new FailNode("fail0000", behaviorTree, unit);

        SelectorNode patrol = new SelectorNode("patrol", behaviorTree, unit);
        patrol.AddChild(fail0000);

        BraceNode brace0000 = new BraceNode("brace0000", behaviorTree, unit);

        SelectorNode dumb_AI_root = new SelectorNode("dumb_AI_root", behaviorTree, unit);
        dumb_AI_root.AddChild(free_engage);
        dumb_AI_root.AddChild(selector0001);
        dumb_AI_root.AddChild(patrol);
        dumb_AI_root.AddChild(brace0000);

        return dumb_AI_root;
    }
}
