GENERAL USE
-----------
- You must have a valid Steam Web API Key. Your key will not be saved or distributed to any party
  other than Valve. Registration for a key can be found here: http://steamcommunity.com/dev/apikey

- You'll need a downloaded copy of the Match History XML file you want to parse.
  Example of how to query the Steam Web API for such a file:
  https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?key=<key>&format=XML
  
- You also have to set a desired output directory. Basically, any folder on your computer to 
  which you have write priviledges.
  
- Once those fields are set, press the 'Download' button and the program will attempt to parse
  the given Match History XML file for Match IDs and then query the Steam Web API for Match
  Details for each Match ID found within. It may take some time as the program is restricted to
  one query every second as to reduce the strain on Valve's servers.