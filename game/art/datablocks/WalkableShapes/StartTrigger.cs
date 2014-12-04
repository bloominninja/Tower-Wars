//-----------------------------------------------------------------------------
// StartTrigger is located at the player spawn point so we can give them some 
// instructions the first time they spawn.
//-----------------------------------------------------------------------------
datablock TriggerData(StartTrigger : DefaultTrigger)
{
   tickPeriodMS = 500;
   WLE_OVERRIDE_PROXY_CLASSTYPE = "LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Server.WalkableShape.StartTrigger";
};