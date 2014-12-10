//-----------------------------------------------------------------------------
// CustomCheetah is a cheetah with a WalkableShape mounted to the roof where
// the turret normally mounts.
//-----------------------------------------------------------------------------
echo("-----------------> Loaded");

datablock WheeledVehicleData(CustomCheetah : CheetahCar)
{
   nameTag = 'Custom Cheetah';
   WLE_OVERRIDE_PROXY_CLASSTYPE = "LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Server.WalkableShape.CustomCheetahCar";
};
echo("-----------------> Loaded");