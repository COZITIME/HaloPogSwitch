# HaloPogSwitch
Tool for customising your Halo: Reach, Halo 4 and Halo 2: Anniversary armour in realtime.  Runs on Halo: The Master Chief Collection for PC with EAC off.

instructions to update: (this needs to be done per halo game)
0: download the pogswitch source code (the file you will be looking in will be )
1: open the halo game, eg go into custom games
2: open cheat engine and attach to halo
3: write down (into notepad or something) and convert your service id to utf-16 hexadecimal (mine is 'e621' so it will turn into "45 00 36 00 32 00 31 00" )
4: add "30 00 30 00 30 00 30 00 00 00" infront of your hexadecimal service id, so mine will now be "30 00 30 00 30 00 30 00 00 00 45 00 36 00 32 00 31 00"
5: search that array of byte that we just made in cheat engine, while attached to MCC
6: if you got any results then good job, if not then go to step 1 (better luck next time, maybe try restarting the game aswell)
7: take the address of the result (it has to be a green address as in its in a specific dll module memory region)
8: add 0x0A to that address
9: you can now copy that address into the pogswitch source code
10: overwrite your address over the value of either `halo2Aoffset`, `halo4offset` or `haloreachoffset` (depending on what game you just did this process for)
11: confirm it works, if it doens't then go back to step 1 (epic fail)
12: make a push request on the github, so it can be formally updated & released as a new release
13: go outside & touch grass
