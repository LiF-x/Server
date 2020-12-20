/**
* <author>Christophe Roblin</author>
* <url>lifxmod.com</url>
* <credits>Nyton for original idea: https://lifeisfeudal.com/forum/alignment-setting-at-every-restart-t14901/#p158603</credits>
* <description>This will adjust alignment for every online player based on settings in LiFx/config.cs</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/
if (!isObject(LiFxAlignment))
{
    new ScriptObject(LiFxAlignment)
    {
    };
}
package LiFxAlignment
{
  function LiFxAlignment::init() {
    LiFxAlignment::AlignmentUpdate();
    echo("LiFxAlignment has been loaded");
  }
  function LiFxAlignment::AlignmentUpdate( ) {
    foreach(%player in PlayerList) %player.changeAlignment($LiFx::AlignmentUpdateDelta);
    LiFxAlignment.schedule($LiFx::AlignmentUpdateMinutes * 60000, AlignmentUpdate);
  }
};
activatePackage(LiFxAlignment);
LiFxAlignment::init();
