# Scrabble Scorer
#### 3.1.4.1, for Fidgetech
#### Date: 8-17-20 by:_**David Boedigheimer**_
### Description
This program is designed to take a user inputted word and then give a score back, based on the scrabble word score system. This program was made with C#.
### BDD Process
1. User can get a value from inputed letter
      * **Input**: z
      * **Output**: 10
2. Progam ignores non alphabetical inputs
      * **Input**: 5
      * **Output**: "This is scrabble, why the numbers?"
3. User can enter a word and get a total returned
      * **Input**: total
      * **Output**: 5
4. Program ignores multible words
      * **Input**: How are you
      * **Output**: Incorrect entry (to many words)
### Setup
* Click on clone or download
* Copy link to clipboard
* Open your preferred terminal
* Navigate to `$cd Desktop`
* Create a folder to house the copy: `$mkdir "Copy"`
* Paste the link, (this is using github): `$git clone "Link"`
* Navigate to the ScrabbleScorerTests folder
* Run `dotnet restore` in the terminal
* Navigate back to the ScrabbleScorer folder
* Run `dotnet build` then `dotnet run', and enjoy.
### Contact
Contact me if you have any concerns or questions at stealth259@gmail.com
### Known bugs
There is one known bug in this program. When multible words are entered, the error message says, "What is with the numbers?" This does not create a error in the response from the program itself.
### License
This program is lisensed under the MIT license.
Copyright (c) 2020 _**David Boedigheimer**_