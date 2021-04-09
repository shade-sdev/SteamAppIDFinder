# SteamAppIDFinder

SteamAppIDFinder is class Library for querying the steam store for APPID.

## Installation

Add the SteamAppIDFinder.dll as reference to your project.

## Usage

```c#
  foreach(string[] array in SteamAppIDFinder.Finder.result(SteamAppIDFinder.Finder.getResponse(), "Grand Theft Auto"))
    {
        Console.WriteLine("Game Name: " + array[0] + " " + "APPID: "+ array[1]);
    }
```

## Output

```
Game Name: Grand Theft Auto V – Bonus $500,000 APPID: 413180
Game Name: Grand Theft Auto V – Bonus $1,500,000 + GTA: San Andreas APPID: 362000
Game Name: Grand Theft Auto V – Bonus $1,500,000 APPID: 362001
Game Name: Grand Theft Auto V – Bonus $1,350,000 APPID: 362002
Game Name: Grand Theft Auto V APPID: 362003
Game Name: Grand Theft Auto III APPID: 12100
Game Name: Grand Theft Auto: Vice City APPID: 12110
Game Name: Grand Theft Auto APPID: 12170
Game Name: Grand Theft Auto 2 APPID: 12180
Game Name: Grand Theft Auto IV APPID: 12219
Game Name: Grand Theft Auto III APPID: 12230
Game Name: Grand Theft Auto: Vice City APPID: 12240
Game Name: Grand Theft Auto: San Andreas APPID: 12250
Game Name: Grand Theft Auto - Episodes from Liberty City Trailer APPID: 5656
Game Name: Grand Theft Auto IV APPID: 5152
Game Name: Grand Theft Auto: San Andreas APPID: 12120
Game Name: Grand Theft Auto V - Criminal Enterprise Starter Pack APPID: 771300
Game Name: Grand Theft Auto V APPID: 271590
Game Name: Grand Theft Auto IV: The Complete Edition APPID: 12210
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
