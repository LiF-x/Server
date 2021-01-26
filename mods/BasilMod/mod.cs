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
