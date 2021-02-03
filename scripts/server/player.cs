datablock PlayerData(DefaultPlayerData)
{
   id = 3;
   sprintTime = 2;        // default is 2
   sprintCooldown = 0;    // default is 2
   className = Armor;
   shapeFile = "art/models/3d/mobiles/characters/male.dts";
   cameraMaxDist = 2.5;
   cameraMinDist = 0.8;
   cameraMaxDistWarStance = 2.5 + 1.2;
   cameraMinDistWarStance = 0.5;
   buildCameraMaxDist = 100;
   buildCameraMinDist = 5;
   buildScopeSize = 10;
   computeCRC = 0;
   warstanceCamAngTheta = 0.4;
   peacestanceCamAngTheta = 0;
   canObserve = 1;
   cmdCategory = "Clients";
   cameraDefaultFov = 75;
   cameraMinFov = 5;
   cameraMaxFov = 120;
   debrisShapeName = "art/shapes/actors/common/debris_player.dts";
   debris = playerDebris;
   aiAvoidThis = 1;
   minLookAngle = -1.2;
   maxLookAngle = 1.2;
   minLookAngleVolley = -1.2;
   maxLookAngleVolley = 1.2;
   maxFreelookAngle = 3;
   lookupdown_animation_angle_min = -1.396;
   lookupdown_animation_angle_max = 1.396;
   mass = 100;
   drag = 1.3;
   maxdrag = 0.4;
   density = 1.1;
   maxDamage = 100;
   maxEnergy = 60;
   repairRate = 0.33;
   energyPerDamagePoint = 75;
   rechargeRate = 0.256;
   runForce = 4320;
   rotSpeedFirstPersonStay = 0.22;
   rotSpeedFirstPersonMove = 0.12;
   rotSpeedThirdPersonStay = 0.22;
   rotSpeedThirdPersonMove = 0.12;
   rotSpeedRotationAnim = 0.32;
   headVThreadMaxSpeedStay = 0.04;
   headVThreadMaxSpeedMove = 0.03;
   mountedRotationAnimationMaxSpeedStay = 0.04;
   mountedRotationAnimationMaxSpeedMove = 0.03;
   maxForwardSpeed = 4;
   maxBackwardSpeed = 3;
   maxSideSpeed = 3;
   maxRuningSpeed = 8;
   maxWarForwardSpeed = 4;      // default is 4
   maxWarBackwardSpeed = 2.5;   // default is 2.5
   maxWarSideSpeed = 4.5;       // default is 4.5
   maxWarRuningSpeed = 8;       // default is 8
   crouchForce = 405;
   maxCrouchForwardSpeed = 4;
   maxCrouchBackwardSpeed = 2;
   maxCrouchSideSpeed = 2;
   equipDrownCoeff = 0.35;
   waterStaminaRate = 0.08;
   O2consumption = 4;
   O2refresh = 20;
   HPdrowning = 5;
   maxUnderwaterForwardSpeed = 4;
   maxUnderwaterBackwardSpeed = 3;
   maxUnderwaterSideSpeed = 3;
   skillSwimmingDistance = 100;
   jumpForce = 900;
   pounceForce = 900;
   jumpDelay = 15;
   airControl = 0.01;
   recoverDelay = 9;
   recoverRunForceScale = 1.2;
   minImpactSpeed = 15;
   impactGroundSpeed = 20;
   speedDamageScale = 1.6;
   boundingBox = "1.5 1 3.5";
   crouchBoundingBox = "1.5 1 3";
   swimBoundingBox = "1 2 2";
   standardRaycastBox = "4.244 4.747 4.246";
   mountingRaycastBox = "4.691 11.666 5.425";
   pickupRadius = 1;
   runSurfaceAngle = 46;
   jumpSurfaceAngle = 80;
   maxStepHeight = 0.5;
   minJumpSpeed = 20;
   maxJumpSpeed = 30;
   knockedDownTicks = 1;
   horizMaxSpeed = 68;
   horizResistSpeed = 33;
   horizResistFactor = 0.35;
   upMaxSpeed = 80;
   upResistSpeed = 25;
   upResistFactor = 0.3;
   groundImpactMinSpeed = 100;
   observeParameters = "0.5 4.5 4.5";
   mainWeapon = SwordWeapon;
   class = "armor";
};
datablock PlayerData(PlayerMaleData : DefaultPlayerData)
{
   id = 400;
   shapeFile = "art/models/3d/mobiles/characters/male.dts";
};
datablock PlayerData(PlayerFemaleData : DefaultPlayerData)
{
   id = 401;
   shapeFile = "art/models/3d/mobiles/characters/female.dts";
   imageScale = "1 1 1";
   horseScale = "0.892 0.892 0.892";
   shapeScale = "0.892 0.892 0.892";
};
datablock CameraData(Observer)
{
   id = 139;
   mode = "Observer";
   useEyePoint = 1;
   firstPersonOnly = 1;
};
datablock PathCameraData(PathCamData)
{
   id = 356;
   useEyePoint = 1;
   firstPersonOnly = 1;
};

