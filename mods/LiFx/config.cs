if (!isObject(LiFx))
{
  new ScriptObject(LiFx)
  {
  };
}

// Activate mods
$LiFx::liveAlignmentActive = false;


/*****************************
*Live Alignment
*
* AlignmentUpdateDelta - How much alignments will the online player get?
* AlignmentUpdateMinutes - How many minutes should it go between updates
*/
$LiFx::AlignmentUpdateDelta = 5;
$LiFx::AlignmentUpdateMinutes = 1;
