//
// DO NOT MODIFY THIS FILE.
//
// This file is automatically generated using the behavior_tree_translator.py script
// on the file: ../../Assets/Behavior Tree Definitions\bt_patrol_and_shoot_ai.xml
//

using BattleTech;


public static class PatrolAndShoot_BT
{
    public static BehaviorNode InitRootNode(BehaviorTree behaviorTree, AbstractActor unit, GameInstance game)
    {
        IsShutDownNode isShutdown0000 = new IsShutDownNode("isShutdown0000", behaviorTree, unit);

        MechStartUpNode mechStartUp0000 = new MechStartUpNode("mechStartUp0000", behaviorTree, unit);

        SequenceNode if_shutdown__restart = new SequenceNode("if_shutdown__restart", behaviorTree, unit);
        if_shutdown__restart.AddChild(isShutdown0000);
        if_shutdown__restart.AddChild(mechStartUp0000);

        IsMovementAvailableForUnitNode movementAvailable0000 = new IsMovementAvailableForUnitNode("movementAvailable0000", behaviorTree, unit);

        IsProneNode isProne0000 = new IsProneNode("isProne0000", behaviorTree, unit);

        StandNode stand0000 = new StandNode("stand0000", behaviorTree, unit);

        SequenceNode if_prone__stand_up = new SequenceNode("if_prone__stand_up", behaviorTree, unit);
        if_prone__stand_up.AddChild(movementAvailable0000);
        if_prone__stand_up.AddChild(isProne0000);
        if_prone__stand_up.AddChild(stand0000);

        IsMovementAvailableForUnitNode movementAvailable0001 = new IsMovementAvailableForUnitNode("movementAvailable0001", behaviorTree, unit);

        HasSensorLockAbilityNode hasSensorLockAbility0000 = new HasSensorLockAbilityNode("hasSensorLockAbility0000", behaviorTree, unit);

        HasSensorLockTargetNode hasSensorLockTarget0000 = new HasSensorLockTargetNode("hasSensorLockTarget0000", behaviorTree, unit);

        SortEnemiesBySensorLockQualityNode sortEnemiesBySensorLockQuality0000 = new SortEnemiesBySensorLockQualityNode("sortEnemiesBySensorLockQuality0000", behaviorTree, unit);

        RecordHighestPriorityEnemyAsSensorLockTargetNode recordHighestPriorityEnemyAsSensorLockTarget0000 = new RecordHighestPriorityEnemyAsSensorLockTargetNode("recordHighestPriorityEnemyAsSensorLockTarget0000", behaviorTree, unit);

        SequenceNode sensor_lock_success = new SequenceNode("sensor_lock_success", behaviorTree, unit);
        sensor_lock_success.AddChild(hasSensorLockAbility0000);
        sensor_lock_success.AddChild(hasSensorLockTarget0000);
        sensor_lock_success.AddChild(sortEnemiesBySensorLockQuality0000);
        sensor_lock_success.AddChild(recordHighestPriorityEnemyAsSensorLockTarget0000);

        ClearSensorLockNode clearSensorLock0000 = new ClearSensorLockNode("clearSensorLock0000", behaviorTree, unit);

        SelectorNode selector0000 = new SelectorNode("selector0000", behaviorTree, unit);
        selector0000.AddChild(sensor_lock_success);
        selector0000.AddChild(clearSensorLock0000);

        SequenceNode evalSensorLock = new SequenceNode("evalSensorLock", behaviorTree, unit);
        evalSensorLock.AddChild(selector0000);

        SuccessDecoratorNode maybe_sensor_lock = new SuccessDecoratorNode("maybe_sensor_lock", behaviorTree, unit);
        maybe_sensor_lock.AddChild(evalSensorLock);

        UnitHasRouteNode unitHasRoute0000 = new UnitHasRouteNode("unitHasRoute0000", behaviorTree, unit);

        LanceHasCompletedRouteNode lanceHasCompletedRoute0000 = new LanceHasCompletedRouteNode("lanceHasCompletedRoute0000", behaviorTree, unit);

        InverterNode inverter0000 = new InverterNode("inverter0000", behaviorTree, unit);
        inverter0000.AddChild(lanceHasCompletedRoute0000);

        LanceHasStartedRouteNode lanceHasStartedRoute0000 = new LanceHasStartedRouteNode("lanceHasStartedRoute0000", behaviorTree, unit);

        LanceStartRouteNode lanceStartRoute0000 = new LanceStartRouteNode("lanceStartRoute0000", behaviorTree, unit);

        SelectorNode selector0001 = new SelectorNode("selector0001", behaviorTree, unit);
        selector0001.AddChild(lanceHasStartedRoute0000);
        selector0001.AddChild(lanceStartRoute0000);

        BlockUntilPathfindingReadyNode blockUntilPathfindingReady0000 = new BlockUntilPathfindingReadyNode("blockUntilPathfindingReady0000", behaviorTree, unit);

        MoveAlongRouteNode moveAlongRoute0000 = new MoveAlongRouteNode("moveAlongRoute0000", behaviorTree, unit);

        SequenceNode move_along_route = new SequenceNode("move_along_route", behaviorTree, unit);
        move_along_route.AddChild(movementAvailable0001);
        move_along_route.AddChild(maybe_sensor_lock);
        move_along_route.AddChild(unitHasRoute0000);
        move_along_route.AddChild(inverter0000);
        move_along_route.AddChild(selector0001);
        move_along_route.AddChild(blockUntilPathfindingReady0000);
        move_along_route.AddChild(moveAlongRoute0000);

        HasSensorLockAbilityNode hasSensorLockAbility0001 = new HasSensorLockAbilityNode("hasSensorLockAbility0001", behaviorTree, unit);

        HasRecordedSensorLockTargetNode hasRecordedSensorLockTarget0000 = new HasRecordedSensorLockTargetNode("hasRecordedSensorLockTarget0000", behaviorTree, unit);

        SetMoodNode setMood0000 = new SetMoodNode("setMood0000", behaviorTree, unit, AIMood.Aggressive);

        SensorLockRecordedSensorLockTargetNode sensorLockRecordedSensorLockTarget0000 = new SensorLockRecordedSensorLockTargetNode("sensorLockRecordedSensorLockTarget0000", behaviorTree, unit);

        SequenceNode choseToSensorLock = new SequenceNode("choseToSensorLock", behaviorTree, unit);
        choseToSensorLock.AddChild(hasSensorLockAbility0001);
        choseToSensorLock.AddChild(hasRecordedSensorLockTarget0000);
        choseToSensorLock.AddChild(setMood0000);
        choseToSensorLock.AddChild(sensorLockRecordedSensorLockTarget0000);

        LanceDetectsEnemiesNode lanceDetectsEnemies0000 = new LanceDetectsEnemiesNode("lanceDetectsEnemies0000", behaviorTree, unit);

        FindDetectedEnemiesNode findDetectedEnemies0000 = new FindDetectedEnemiesNode("findDetectedEnemies0000", behaviorTree, unit);

        IsAttackAvailableForUnitNode attackAvailable0000 = new IsAttackAvailableForUnitNode("attackAvailable0000", behaviorTree, unit);

        SortEnemiesByThreatNode sortEnemiesByThreat0000 = new SortEnemiesByThreatNode("sortEnemiesByThreat0000", behaviorTree, unit);

        UseNormalToHitThreshold useNormalToHitThreshold0000 = new UseNormalToHitThreshold("useNormalToHitThreshold0000", behaviorTree, unit);

        WasTargetedRecentlyNode wasTargetedRecently0000 = new WasTargetedRecentlyNode("wasTargetedRecently0000", behaviorTree, unit);

        InverterNode inverter0001 = new InverterNode("inverter0001", behaviorTree, unit);
        inverter0001.AddChild(wasTargetedRecently0000);

        RandomPercentageLessThanBVNode randomPercentageLessThanBV0000 = new RandomPercentageLessThanBVNode("randomPercentageLessThanBV0000", behaviorTree, unit, BehaviorVariableName.Float_PriorityAttackPercentage);

        SortEnemiesByPriorityListNode sortEnemiesByPriorityList0000 = new SortEnemiesByPriorityListNode("sortEnemiesByPriorityList0000", behaviorTree, unit);

        SequenceNode sequence0000 = new SequenceNode("sequence0000", behaviorTree, unit);
        sequence0000.AddChild(inverter0001);
        sequence0000.AddChild(randomPercentageLessThanBV0000);
        sequence0000.AddChild(sortEnemiesByPriorityList0000);

        MaybeFilterOutPriorityTargetsNode maybeFilterOutPriorityTargets0000 = new MaybeFilterOutPriorityTargetsNode("maybeFilterOutPriorityTargets0000", behaviorTree, unit);

        FilterKeepingRecentAttackersNode filterKeepingRecentAttackers0000 = new FilterKeepingRecentAttackersNode("filterKeepingRecentAttackers0000", behaviorTree, unit);

        SucceedNode succeed0000 = new SucceedNode("succeed0000", behaviorTree, unit);

        SelectorNode priorityAttack = new SelectorNode("priorityAttack", behaviorTree, unit);
        priorityAttack.AddChild(sequence0000);
        priorityAttack.AddChild(maybeFilterOutPriorityTargets0000);
        priorityAttack.AddChild(filterKeepingRecentAttackers0000);
        priorityAttack.AddChild(succeed0000);

        ShootAtHighestPriorityEnemyNode shootAtHighestPriorityEnemy0000 = new ShootAtHighestPriorityEnemyNode("shootAtHighestPriorityEnemy0000", behaviorTree, unit);

        SequenceNode opportunity_fire = new SequenceNode("opportunity_fire", behaviorTree, unit);
        opportunity_fire.AddChild(lanceDetectsEnemies0000);
        opportunity_fire.AddChild(findDetectedEnemies0000);
        opportunity_fire.AddChild(attackAvailable0000);
        opportunity_fire.AddChild(sortEnemiesByThreat0000);
        opportunity_fire.AddChild(useNormalToHitThreshold0000);
        opportunity_fire.AddChild(priorityAttack);
        opportunity_fire.AddChild(shootAtHighestPriorityEnemy0000);

        BraceNode brace0000 = new BraceNode("brace0000", behaviorTree, unit);

        SelectorNode patrol_and_shoot_AI_root = new SelectorNode("patrol_and_shoot_AI_root", behaviorTree, unit);
        patrol_and_shoot_AI_root.AddChild(if_shutdown__restart);
        patrol_and_shoot_AI_root.AddChild(if_prone__stand_up);
        patrol_and_shoot_AI_root.AddChild(move_along_route);
        patrol_and_shoot_AI_root.AddChild(choseToSensorLock);
        patrol_and_shoot_AI_root.AddChild(opportunity_fire);
        patrol_and_shoot_AI_root.AddChild(brace0000);

        return patrol_and_shoot_AI_root;
    }
}
