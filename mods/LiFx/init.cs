exec("./config.cs");


// Scripts
if($LiFx::liveAlignmentActive) {
  exec("./scripts/onlineAlignment/onlineAlignment.cs");
}