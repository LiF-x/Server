if (!isObject(BasilMod))
{
    new ScriptObject(BasilMod)
    {
    };
}
if (!isObject(BasilMod._callbackObject))
{
  BasilMod._callbackObject = new ArrayObject();
}

// $LiFx::hooks::onSpawnCallbacks =  JettisonArray();
// $LiFx::hooks::onConnectCallbacks =  JettisonArray();
// $LiFx::hooks::onDisconnectCallbacks =  JettisonArray();

// $LiFx::hooks::onDeathCallbacks =  JettisonArray();
// $LiFx::hooks::onKillCallbacks =  JettisonArray();

// $LiFx::hooks::onJHStartCallbacks =  JettisonArray();
// $LiFx::hooks::onJHEndCallbacks =  JettisonArray();
// $LiFx::hooks::onCharacterCreateCallbacks =  JettisonArray();

// $LiFx::hooks::onStartCallbacks =  JettisonArray();
// $LiFx::hooks::onPostInitCallbacks  =  JettisonArray();
// $LiFx::hooks::onInitServerCallbacks  =  JettisonArray();
// $LiFx::hooks::onInitServerDBChangesCallbacks  =  JettisonArray();

// art\models\3d\construction\fortifications\stone_wall4m_gate_middle


if (!isObject(LifXBasilModLoader))
{
    new ScriptObject(LifXBasilModLoader)
    {
    };
}
package LifXBasilModLoader
{
  function LifXBasilModLoader::setup() {
    LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks, Load, LifXBasilModLoader);
  }

  function LifXBasilModLoader::Load() {
    exec("BasilMod/pack/pack.cs");
  }
};
activatePackage(LifXBasilModLoader);
LiFx::registerCallback($LiFx::hooks::mods, setup, LifXBasilModLoader);