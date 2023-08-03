using System;

namespace ChooseYourAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("Welcome to the multiverse!");
            Console.WriteLine("You find yourself in a mysterious world with strange characters around and a strange journey.");
            Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.WriteLine("Enter your name ____");
                string Player = Console.ReadLine();

                Console.WriteLine("what is the name of your journey? (Journey to _______ )");
                string Journey;
                Journey = Console.ReadLine();
                




            // Storyline 1: Shrek Encounter
            Console.WriteLine("You encounter Shrek, who challenges you to a dance-off. Will you...");
            Console.WriteLine("1 - Accept the challenge and show off your dance moves");
            Console.WriteLine("2 - Politely decline and ask Shrek about his swamp");
            Console.WriteLine("enter - ignore");

            string ans = Console.ReadLine();

            if (ans == "1")
            {
                // Outcome 1: Dance-Off with Shrek
                Console.WriteLine(Player + " start dancing like there's no tomorrow, and surprisingly, Shrek is impressed!");
                Console.WriteLine("He rewards " + Player + " with a bag of onions and offers to be your dance partner in the future.");
                Console.WriteLine("You gain +10 Dance Skills and +5 Friendship with Shrek.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();

                // Storyline 2: The Mysterious Chest
                Console.WriteLine("As "+ Player + " continues their journey to " + Journey + ", they come across a mysterious chest.");
                Console.WriteLine("Will you...");
                Console.WriteLine("1 - Open the chest");
                Console.WriteLine("2 - Ignore the chest and keep moving forward");

                string chestChoice = Console.ReadLine();
                if (chestChoice == "1")
                {
                    // Outcome 2.1: Open the Chest
                    Console.WriteLine(Player + " decides to open the chest, and to your surprise, it's filled with gold and treasures!");
                    Console.WriteLine("You gain +100 Gold and +20 Luck.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    
Console.WriteLine("As you marvel at the treasure, a small cat with striking blue eyes approaches you.");
Console.WriteLine("The cat introduces itself as Maxwell and claims to be a carryable companion.");
Console.WriteLine("Maxwell seems friendly and offers to join you on your journey to " + Journey);
Console.WriteLine("Will " + Player + "...");
Console.WriteLine("1 - Accept Maxwell as your companion");
Console.WriteLine("2 - Politely decline and continue on your own");

string maxwellChoice = Console.ReadLine();
if (maxwellChoice == "1")
{
    // Outcome 2.1.1: Accept Maxwell as your Companion
    Console.WriteLine(Player + " gladly accepts Maxwell as their carryable companion.");
    Console.WriteLine("From now on, Maxwell will accompany you and provide support in your adventures.");
    Console.WriteLine("You gain +10 Cuteness and +5 Luck.");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();

    Console.WriteLine("As you and your newfound companion continue your journey, you encounter a mysterious figure in a dark cloak.");
    Console.WriteLine("The figure seems to be following you, but every time you turn, they disappear.");
    Console.WriteLine("Will you...");
    Console.WriteLine("1 - Investigate the mysterious figure");
    Console.WriteLine("2 - Ignore them and continue on your adventure");

    string cloakFigureChoice = Console.ReadLine();
    if (cloakFigureChoice == "1")
    {
        // Outcome 2.1.1.1: Investigate the Mysterious Figure
        Console.WriteLine("You decide to investigate the mysterious figure.");
        Console.WriteLine("As you get closer, they reveal themselves to be a cloaked person named Selene.");
        Console.WriteLine("Selene tells you that she's secretly part of the dark side and has been observing you.");
        Console.WriteLine("She offers you a choice to join the dark side or face her in battle.");
        Console.WriteLine("Will you...");
        Console.WriteLine("1 - Join the dark side");
        Console.WriteLine("2 - Refuse to join and prepare for a battle with Selene");

        string seleneChoice = Console.ReadLine();
        if (seleneChoice == "1")
        {
            // Outcome 2.1.1.1.1: Join the Dark Side
            Console.WriteLine("You're tempted by Selene's offer and decide to join the dark side.");
            Console.WriteLine("Maxwell, your trusted companion, seems uneasy about your decision.");
            Console.WriteLine("You gain +100 Dark Power, but you lose Maxwell's trust.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            
    // TODO: Add continuation of the story based on the player's choice to join the dark side.

    Console.WriteLine("As you embrace the dark side, your powers grow stronger, but at what cost?");
    Console.WriteLine("Your once unbreakable bond with Maxwell begins to crack.");
    Console.WriteLine("Your actions draw the attention of other powerful beings seeking to control your newfound power.");
    Console.WriteLine("You are faced with difficult decisions, leading you further down the path of darkness.");
    Console.ReadLine();

    Console.WriteLine("Years pass, and you become a formidable force, feared and respected across the multiverse.");
    Console.WriteLine("However, the whispers of your past life haunt you, and a part of you longs for redemption.");
    Console.ReadLine();


    Console.WriteLine("One fateful day, you encounter an ancient artifact that has the power to rewrite history.");
    Console.WriteLine("The artifact offers you the chance to undo your decision to join the dark side and restore your bond with Maxwell.");
    Console.WriteLine("Will you...");
    Console.WriteLine("1 - Use the artifact to change your past and redeem yourself");
    Console.WriteLine("2 - Embrace your dark path and seek even more power");

    string artifactChoice = Console.ReadLine();
    if (artifactChoice == "1")
    {
        // Outcome 2.1.1.1.1.1: Use the Artifact for Redemption
        Console.WriteLine("You choose redemption and use the artifact to rewrite your past.");
        Console.WriteLine("Your memories of joining the dark side fade, and you find yourself back at the crossroads of your original journey.");
        Console.WriteLine("This time, you make a different choice, staying true to your principles.");
        Console.WriteLine("You regain Maxwell's trust and strengthen your bond with your companion.");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Your heart feels lighter as you continue your journey to " + Journey + ", striving to protect the multiverse.");
        Console.WriteLine("Though the darkness still tempts you, you now have the strength to resist.");
        Console.WriteLine("You become a beacon of hope, inspiring others to choose the path of good.");
        Console.WriteLine("but, that power hungry side of you still exists within your subconsious just waiting to someday burst out of you and take full control of you");
        Console.WriteLine("you continue to live your life as peaceful as possible");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("little do you know.");
        Console.ReadLine();
        Console.WriteLine("by going back in time..");
        Console.ReadLine();
        Console.WriteLine("you create an endless amounts of universe's...");
        Console.ReadLine();
        Console.WriteLine("while also turning your previous world to ruins....");
        Console.ReadLine();
        Console.WriteLine("with no way to ever return things to normal.....");
        Console.ReadLine();
        Console.WriteLine("You forever live with this information in mind......");
        Console.ReadLine();

        // TODO: Continue the story, wrapping up the adventure with the player's choice for the ending.

        Console.WriteLine("You have reached the end, thanks for playing!");
        Console.ReadLine();
        Console.WriteLine("Press ctrl + C to close");
        Console.ReadLine();
    }
    else if (artifactChoice == "2")
    {
        // Outcome 2.1.1.1.1.2: Embrace the Dark Path
        Console.WriteLine("You cannot resist the temptation of power and decide to embrace your dark path.");
        Console.WriteLine("The artifact remains untouched as you continue your new journey as a dark force.");
        Console.WriteLine("You become even more feared and respected, wielding immense power across the multiverse.");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Your actions become more ruthless, and you lose sight of your former self.");
        Console.WriteLine("Your bond with Maxwell is all but forgotten, and your heart grows colder.");
        Console.ReadLine();

        Console.WriteLine("One day, as you stand at the peak of your power, you are confronted by someone from your past.");
        Console.WriteLine("A former friend or ally, whose life you changed forever by joining the dark side.");
        Console.WriteLine("He approaches you wearing a cloak begging you to return to who you once were");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("but to no avail");
        Console.ReadLine();
        Console.WriteLine("will you...");
        Console.WriteLine("1 - sentence your former friend to execution");
        Console.WriteLine("2 - banish them");

        string ASD = Console.ReadLine();

        if (ASD == "1")
        {
            // Outcome 2.1.1.1.1.2.1: Sentence Maxwell to Execution
    Console.WriteLine("Your heart hardens, and you choose to sentence Maxwell to execution.");
    Console.WriteLine("He pleads one last time, but you remain resolute, not letting your emotions waver.");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();

    Console.WriteLine("As Maxwell's life force fades away, you feel an overwhelming sense of power.");
    Console.WriteLine("Your grip on the dark side tightens, and the last traces of light within you diminish.");
    Console.WriteLine("In that moment, you fully embrace the darkness, becoming the ruler of a chaotic multiverse.");
    Console.WriteLine("Your journey ends with the complete dominion of darkness.");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();

    // TODO: Continue the story, wrapping up the adventure with the player's choice for the ending.

    Console.WriteLine("Tell me, did you make the right choice?");
    Console.ReadLine();
    Console.WriteLine("Doesn's matter... you made your choice");
    Console.ReadLine();
    Console.WriteLine("Hope youre satisfied as the story ends here");
    Console.ReadLine();
        }
        else if (ASD == "2")
        {
             // Outcome 2.1.1.1.1.2.2: Banish Maxwell
    Console.WriteLine("Though the darkness is strong, you still cannot bear to harm Maxwell.");
    Console.WriteLine("With a heavy heart, you choose to banish him from your presence.");
    Console.WriteLine("Maxwell pleads once more, but you turn your back on him.");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();

    Console.WriteLine("As Maxwell walks away, you feel a pang of remorse, but you suppress it.");
    Console.WriteLine("Your commitment to the dark side remains unwavering.");
    Console.WriteLine("With Maxwell gone, you are free to continue your quest for even more power.");
    Console.WriteLine("You are now a solitary force, feared and respected across the multiverse.");
    Console.ReadLine();



    Console.WriteLine("The end");
    Console.ReadLine();
        }
        else if (ASD == "Freedom")
        {
            Console.WriteLine("by using a secret tecnique passed down by the family of maxwells");
            Console.WriteLine("Maxwell enters the spirit realm and enters " + Player + "'s heart and forces them");
            Console.WriteLine("to face the error of their ways");
            Console.ReadLine();
            Console.WriteLine("some time after " + Player + " was forced to face the error of his ways he gave up his power and");
            Console.WriteLine("under Maxwell's demands, " + Player + "'s punishment will be to return to the person they once were");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("A friend");
            Console.ReadLine();
            Console.WriteLine("Congrats, you got secret ending #1");
            Console.ReadLine();
            Environment.Exit(0);

        }
        else if (ASD == "Terror")
        {
            Console.WriteLine("as " + Player + " gets ready to execute Maxwell...");
            Console.WriteLine("the voice...");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("'Impending doom aproaches'");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("gets replayed over and over inside of " + Player + "'s head, slowly driving them to insanity");
            Console.WriteLine("before they knew it, Cthulhu is summoned right before their very eyes");
            Console.WriteLine("Along with Hades, groups of Titans, Amaterasu, Kratos, Pokemon Arceus, Goku, and the worst of em all ");
            Console.ReadLine();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.WriteLine("..");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("A Cheesecake");
            Console.ReadLine();
            Console.WriteLine("By the power of all these mofo's, " + Player + " is punished for his doings and is sentenced to eternity in the backrooms");
            Console.ReadLine();
            Console.WriteLine("Congrats, you got secret ending #2");
            Console.ReadLine();
            Environment.Exit(0);
        }

//ending 1 ^        









        

    }

            // TODO: Add continuation of the story based on the player's choice to join the dark side.
        }
        else if (seleneChoice == "2")
        {
            // Outcome 2.1.1.1.2: Refuse to Join and Prepare for Battle
            Console.WriteLine("You refuse to join the dark side and prepare for a battle with Selene.");
            Console.WriteLine("Selene reveals her true form as a powerful sorceress, and the battle begins.");
            Console.WriteLine("You and Maxwell fight together, using your skills and teamwork to face Selene.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Will you...");
            Console.WriteLine("1 - bitch slap that hoe");
            Console.WriteLine("2 - have maxwell do a Super-Duper-Mega-Awsomeness attack");

            string SeleneFight = Console.ReadLine();

            if (SeleneFight == "1")
            {
                Console.WriteLine("You folded that bitch Selene in half and sent her to the next dimention");
                Console.WriteLine("You and maxwell shrug off the encounter and continue on your journey");
                Console.WriteLine("press enter");
                Console.ReadLine();
                Console.WriteLine("after walking for a hot minute, you and Maxwell encounter a wild mexican running from border patrol");
                Console.WriteLine("You think for a moment on what you think you want to do about the situation");
                Console.WriteLine("1 -  do you want to take time out of your day and help him flee");
                Console.WriteLine("2 -  ignore him");

                string Mexican = Console.ReadLine();

                if (Mexican == "1")
                {
                    Console.WriteLine("you pull out your taco launcher and poison border patrol with immigration-disease, effectively revoking their US citizenship");
                    Console.WriteLine("name the mexican - ");

                    string MName;
                    MName = Console.ReadLine();
                    
                    Console.WriteLine("catching his breath, " + MName + " thanks you and tags along on your Journey to " + Journey);
                    Console.WriteLine("It starts to rain and darken so you set up camp behind a tree");
                    Console.WriteLine("luckily for you guys, " + MName + " knows how to assemble a tent");
                    Console.WriteLine("and slept like kings that night");
                    Console.WriteLine("press enter");
                    Console.ReadLine();
                    Console.WriteLine("+10 Friendship with Maxwell and " + MName);
                    Console.WriteLine("+5 cleanliness");
                    Console.WriteLine("press enter");
                    Console.WriteLine("continuing the journey, you and your friends stumble upon Daryl?");
                    Console.WriteLine("whos Daryl you may ask?");
                    Console.WriteLine("well the guy from fortnite of course");
                    Console.WriteLine("looks like he is enjoying his life and htting the griddy");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.WriteLine("daryl notices you and starts cranking 90s");
                    Console.WriteLine("1 - run");
                    Console.WriteLine("2 - fight back");

                    string DChoice = Console.ReadLine();

                    if (DChoice == "1")
                    {
                        Console.WriteLine("you guys run for your lifes");
                        Console.WriteLine("press enter");
                        Console.ReadLine();
                        Console.WriteLine("Daryl Didnt stick the landing (57 m)");
                    }
                    else if (DChoice == "2")
                    {
                        Console.WriteLine("to get some training in, Maxwell volunteers and also cranks 90s");
                        Console.WriteLine("Press enter");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("In a valiant effort, Maxwell manages to eliminate Daryl with clingers?");
                        Console.WriteLine("if it works it works i guess");
                    }


                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    Console.WriteLine("after Daryl's death, you, Maxwell, and " + MName + " continue on your Journey");
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    Console.WriteLine("after what felt like forever, you enivatebly fall into a deep depression and wonder");
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    Console.WriteLine("Will you ever achieve your journey to " + Journey);
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    Console.WriteLine("Maxwell does a dance for you to try and cheer you up");
                    Console.WriteLine("does it work?");
                    Console.WriteLine("yes");
                    Console.WriteLine("no");

                    string MaxDec = Console.ReadLine();

                    if (MaxDec == "yes")
                    {Console.WriteLine("'Thank you maxwell, but i dont think ill make it, but thats alright, i met you and " + MName);
                    Console.WriteLine("and I am so happy for that, but i think my body is starting to fail me");
                    Console.WriteLine("thats a shame, maybe i can continue this journey somewhere else.'");
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    Console.WriteLine("with that, the protagonist of this story later dies in his sleep due to what only one can theorize to be Fucks-To-Give-Ran-Out-Syndrome");
                    Console.WriteLine("how tragic");
                    Console.WriteLine("");
                    Console.WriteLine("The End");
                    Console.ReadLine();


                    }




//Mexican joins ^
//Mexican run away v

                }
                else if (Mexican == "2")
                {
                    Console.WriteLine("You ignored the Running burrito and continued on your journey");
                    Console.WriteLine("It starts to rain and darken so you set up camp behind a tree");
                    Console.WriteLine("you and maxwell have no clue how to assemble a tent but try your best anyways");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();

                    Console.WriteLine("after struggling setting up the tent, you guys give up and just hang a sheet off the tree to act as a mini fort");
                    Console.WriteLine("but ended up soaking in the rain all night");
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("out of anger");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("maxwell decided to show his true intentions when he decided to approach you");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("the reason Selene was following you was because your DNA has been infused with Ligma");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("so that is why...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("you must die");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine(Player);
                    Console.ReadLine();
                    Console.WriteLine(Player + " is in shock and doesnt know what to do");
                    Console.WriteLine("1 - surrender");
                    Console.WriteLine("2 - fight back");

                    string FightMax = Console.ReadLine();

                    if (FightMax == "1")
                    {
                        Console.WriteLine(Player + " surrenders");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("Maxwell prepares to execute you");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("signature move, 1000 paw slice'");
                        Console.ReadLine();
                        Console.WriteLine("Game Over ඞ");
                        Console.ReadLine();
                        Environment.Exit(0);
                       

                    }
                    else if (FightMax == "2")
                    {
                        Console.WriteLine(Player + " gets ready to fight but gets caught off guard by.");
                        Console.ReadLine();
                        Console.WriteLine("by..");
                        Console.ReadLine();
                        Console.WriteLine("by.......");
                        Console.ReadLine();
                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                        Environment.Exit(0);
                        
                    }
                }


            }
            else if (SeleneFight == "2")
            {
                Console.WriteLine("You throw maxwell into the air and have him unleash is ultimate move...");
                Console.WriteLine("press enter");
                Console.ReadLine();
                Console.WriteLine(" ___                         _              ___ ");
                                Console.ReadLine();

                Console.WriteLine("| . | ___  _ _ _  ___  _ _  | |   ___  ___ | | '");
                                Console.ReadLine();

                Console.WriteLine("|  _// . || | | |/ ._>| '_> | |_ / . |<_> || |- ");
                                Console.ReadLine();

                Console.WriteLine("|_|  |___/|__/_/ |___.|_|   |___||___/<___||_|  ");
                                Console.ReadLine();
                Console.WriteLine("Maxwell uses his secret tecnique, Power Loaf, to slam Selene");
                Console.WriteLine("Exhausted, Maxwell takes a quick 2 second nap to recharge and continue your journey to " + Journey);
                Console.ReadLine();
                Console.WriteLine("you and maxwell head into the unknown");
                Console.ReadLine();
                 Console.WriteLine("As you venture deeper into the unknown With Maxwell, you come across a dark forest.");
    Console.WriteLine("The forest is said to be haunted by restless spirits.");
    Console.WriteLine("Will you...");
    Console.WriteLine("1 - Enter the dark forest and face the haunted spirits");
    Console.WriteLine("2 - Find a different path to avoid the forest");

    string darkForestChoice = Console.ReadLine();
    if (darkForestChoice == "1")
    {
        // Outcome 2.1.2.1: Enter the Dark Forest
        Console.WriteLine("You decide to enter the dark forest, prepared to face the haunted spirits.");
        
    }
    else if (darkForestChoice == "2")
    {
        Console.WriteLine("Your mom shows up out of nowhere and scares you into the forest");
    }

    Console.WriteLine("The atmosphere is eerie and filled with ghostly apparitions.");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Then all of a sudden, Hitler's Ghost jumpscares you");
        Console.WriteLine("he summons his group of nazi's to take you with him and brainwash you and Maxwell");
        Console.ReadLine();
        Console.WriteLine("what will you do?");
        Console.WriteLine("this time, type it out yourself :3");
        String HitEnc = Console.ReadLine();

        Console.WriteLine(Player + " " + HitEnc + " Hitler, defeating him and his army");
        Console.ReadLine();
        Console.WriteLine("Passing thr0ugh the dark for3-");
        Console.ReadLine();
        Console.WriteLine("Y0u s33 a mxn stxnd1n9 al0-");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("y0u7 f3el lI9h7 h3Ad3d");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("bAr3l7 5tand1n9...");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("...");
        Console.ReadLine();
        Console.WriteLine("m4xw311 f4d3s aw4ay");
        Console.ReadLine();
        Console.WriteLine("ŷ̴͙͖̦̯͇͚̞͇̯̣̬̔̓͂̿́͛̌̊͋͗̓͘͘o̵͍͖̥̅̎͌̈͝͝ṷ̷̩̣͗͑̆̎̀̈́̀͌͛̈́̓͛̓̕͝ ̵̛͔̰̯̬̗͂̔͛͗̇̑̽̽b̶̢̢͎̪͍̜̤̤͊͂̾̃́̄͛̅̎̃̍l̵̨̛̹͖̥͙͆͒̏̓̓̚a̸͕̼̳̒̽̒̀̇̊̈́̆͒̂̔̋c̷͕͉̰͓̺͍̟̦͍͝k̷̛̛̰͙̲̯̙̼͍̺͓̗̏̃͑̒̋̽̉̾̃̿̾͜͝͝ͅ ̴̙͉͆̋̔͛̄̌̔͒̕̚͝ǒ̵̮͈̐͂̇̊̉̈́̃̆͘̚͜͝û̷̼͇̞͕̔͋̀͂͐̄͗̈́̀͛͘̕͘ͅṯ̸̛̖̪̌́̃͛͐́̍͘");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("...");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("Thank you for playing the demo :3");
        Console.ReadLine();
        Console.ReadLine();

                
            }
// blue bracket is maxwell ^





            
            



            // TODO: Add continuation of the story based on the player's choice to battle Selene.
        }
        else
        {
            // Outcome 2.1.1.1: Indecisive Response
            Console.WriteLine("You stand there indecisively, and Selene Turns you and maxwell to ash.");
            Console.WriteLine("Game over nooooooob(ctrl + c)");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
    else if (cloakFigureChoice == "2")
    {
        // Outcome 2.1.1.2: Ignore the Mysterious Figure
        Console.WriteLine("You decide to ignore the mysterious figure and continue your adventure.");
        Console.WriteLine("Maxwell keeps an eye on them from your shoulder.");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Suddenly");
        Console.ReadLine();
        Console.WriteLine("spiderman and Minecraft steve show up infront of you, fighting?");
        Console.WriteLine("they both notice you and yell for your help");
        Console.WriteLine("who do you team up with?");
        Console.WriteLine("1 - spiderman");
        Console.WriteLine("2 - steve");
        string hero = Console.ReadLine();

        if (hero == "spiderman")
        {
            Console.WriteLine("you signaled to spiderman that youre on his side ");
            Console.WriteLine("both of you take down steve and default dance on his ass");
            Console.ReadLine();

        }
        else if (hero == "steve")
        {
            Console.WriteLine("you signaled to steve that youre on his side");
            Console.WriteLine("both of you take down spiderman and griddy on his ass");
            Console.ReadLine();
        }

        Console.WriteLine("he say thank you and get dragged through a portal, leaving you wondering where it leads");
        Console.ReadLine();
        Console.WriteLine("it starts to turn dark and you get a weird feeling");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("You feel an evil presence watching you...");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("1 - do you want to run and find shelter");
        Console.WriteLine("2 - or stay and and feed your curiosity");

        string run = Console.ReadLine();

        if (run == "1")
        {
            Console.WriteLine("you find shelter and wait till it turns day");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("you cook up some food and share it with maxwell, he loves it");
            Console.WriteLine("+10 friendship +3 trust");
            Console.ReadLine();
            Console.WriteLine("you rest till day time");
        }
        else if (run == "2")
        {
            Console.WriteLine("you stay outside and wait");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("at the very edge of your vision, you manage to catch something fly across");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("a giant eye charges at you from behind and only manage to survive as maxwell was on your shoulder, ready to warn you");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("you dont know what to do");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("the giant eye is in the air spewing out smaller eyes that charge at you");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("you barely manage to dodge them");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine(Player + " and maxwell look at eachother and grin");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("they had a secret up their sleeve");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("they pulled out a gun and 360 no scoped the eye of cthulhu because that makes sense");
            Console.WriteLine("");
            Console.ReadLine();
        }

            
            Console.WriteLine("A few hours pass and you make your way down the yellow brick road");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("still on your journey to " + Journey);
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("you look at the sky and think");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("noticing a weird mushroom in the sky, you laugh and smile without giving it a second thou-");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("");
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            



        
    }
    else
    {
        // Outcome 2.1.1: Indecisive Response
        Console.WriteLine("You stand there indecisively, and the mysterious figure vanishes.");
        Console.WriteLine("cunt, restart and pick something.");
        Console.ReadLine();
    }
}
else if (maxwellChoice == "2")
{
    // Outcome 2.1.2: Politely Decline Maxwell's Offer
    Console.WriteLine("You politely decline Maxwell's offer and continue your adventure on your own.");
    Console.WriteLine("Maxwell looks disappointed...");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
    Console.WriteLine("And kills you");
    Console.WriteLine("Game Over");
    Console.ReadLine();
    Environment.Exit(0);

   
}



                }
                else if (chestChoice == "2")
                {
                    // Outcome 2.2: Ignore the Chest
                    Console.WriteLine(Player + " ignores the chest and continues on their adventure.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You stand there indecisively and nothing happens.");
                    Console.WriteLine("restart and pick something cunt.");
                    Console.ReadLine();
                }

                // Storyline 3: Encounter with Michael Myers (comes after saying no to opening chest)
                Console.WriteLine("As you venture deeper into the unknown, you encounter a fearsome creature: Michael Myers!");
                Console.WriteLine("Will you...");
                Console.WriteLine("1 - Run Away from Myers Michael");
                Console.WriteLine("2 - Engage in a battle with Michael Myers");

                string michaelChoice = Console.ReadLine();
                if (michaelChoice == "1")
                {
                    // Outcome 3.1: run away from Michael Myers
                    Console.WriteLine("you run away from the white boy");
                    Console.WriteLine("luckily for you he slow af and managed to get away");
                    Console.ReadLine();
                    Console.WriteLine("if only it wernt for plot armor");
                    Console.WriteLine("while you were looking behind you to see if he was following you...");
                    Console.WriteLine("michael myers showed up directly infront of you and you run into him, cuasing you to trip");
                    Console.WriteLine("and die because you stubbed your toe on a missplaced atom smhs my watermelon head you ");
                    Console.WriteLine("stupid dumb clumsy mofo");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("hell, a sloth could run away from michael myers a lot better than you could LMAOLMAOLMAO");
                    Console.ReadLine();
                    Environment.Exit(0);


                }
                else if (michaelChoice == "2")
                {
                    // Outcome 3.2: Battle with Michael Myers (Assuming a Pokemon-like battle)
                   Console.WriteLine("bro");
                   Console.WriteLine("");
                   Console.ReadLine();
                   Console.WriteLine("its michael myers");
                   Console.WriteLine("");
                   Console.ReadLine();
                   Console.WriteLine("nah man");
                   Console.WriteLine("");
                   Console.ReadLine();
                   Console.WriteLine("ima go ahead and /kill @" + Player + " since your ass is gonna die anyways 💀");
                   Console.WriteLine("");
                   Console.ReadLine();
                   Console.WriteLine("Game Over");
                   Console.ReadLine();
                   Environment.Exit(0);

                }
                
                else
                {
                    Console.WriteLine("You freeze in fear, and Michael Myers approaches slowly...");
                    Console.WriteLine("It's the end of the line for you.");
                    Console.WriteLine("GAME OVER.");
                    Console.WriteLine("Press Enter to exit.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else if (ans == "2")
            {
                // Outcome 4: Ask Shrek About His Swamp
                Console.WriteLine("You ask Shrek about his swamp, and he starts sharing his life stories.");
                Console.WriteLine("As you listen, you realize that Shrek is a deep and thoughtful ogre.");
                Console.WriteLine("You gain +5 Friendship with Shrek.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();

                // Storyline 4: Encounter with Crewmate from Among Us
                Console.WriteLine("As you continue your journey, you come across a peculiar sight: Crewmate from Among Us.");
                Console.WriteLine("Crewmate seems to be in distress and needs your help.");
                Console.WriteLine("Will you...");
                Console.WriteLine("1 - Offer to help Crewmate find its spaceship");
                Console.WriteLine("2 - Ignore Crewmate and continue on your adventure");
                

                string crewmateChoice = Console.ReadLine();
                if (crewmateChoice == "1")
                {
                    // Outcome 4.1: Help Crewmate Find Its Spaceship
                    Console.WriteLine("You decide to help Crewmate find its spaceship.");
                    Console.WriteLine("Crewmate thanks you and rewards you with a special Crewmate pet that follows you on your journey.");
                    Console.WriteLine("You gain +10 Kindness and +5 Luck.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (crewmateChoice == "2")
                {
                    // Outcome 4.2: Ignore Crewmate
                    Console.WriteLine("You decide to ignore Crewmate and continue your adventure.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                
                else
                {
                    Console.WriteLine("You stand there indecisively, and Crewmate gets bored waiting for your response and eats you.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                // Storyline 5: Encounter with Thomas the Thermonuclear Bomb
                Console.WriteLine("As you venture deeper into the unknown, you encounter Thomas the thermonuclear bomb.");
                Console.WriteLine("Thomas looks at you menacingly, but it seems he wants to have a conversation.");
                Console.WriteLine("Will you...");
                Console.WriteLine("1 - Engage in a serious discussion with Thomas about Cereal");
                Console.WriteLine("2 - Attempt to disarm Thomas");

                string thomasChoice = Console.ReadLine();
                if (thomasChoice == "1")
                {
                    // Outcome 5.1: Serious Discussion with Thomas
                    Console.WriteLine("You engage in a serious discussion with Thomas about Cereal.");
                    Console.WriteLine("Thomas appreciates your deep thoughts and gives you a book of philosophical quotes.");
                    Console.WriteLine("You gain +68 Wisdom.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (thomasChoice == "2")
                {
                    // Outcome 5.3: Attempt to Disarm Thomas
                    Console.WriteLine("You attempt to disarm Thomas, but it's no use.");
                    Console.WriteLine("Thomas is too Thicc and blows up.");
                    Console.WriteLine("Game Over");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You stand there indecisively, and Thomas gives you a knowing look and oth of you just die from lemon.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else
            {
                // Outcome 6: Hesitate with Shrek
                Console.WriteLine("He walks away angrily, leaving you standing therelike a loser who just got rejected by the mirror while practicing to ask someone out.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();

                // Storyline 6: Encounter with Floating Walmart
                Console.WriteLine("As you stand there, a bright light shines from the sky, and a floating Walmart appears!");
                Console.WriteLine("The floating Walmart seems to be offering you something.");
                Console.WriteLine("Will you...");
                Console.WriteLine("1 - Approach the floating Walmart to see what it wants");
                Console.WriteLine("2 - Ignore the floating Walmart and continue your adventure");

                string walmartChoice = Console.ReadLine();
                if (walmartChoice == "1")
                {
                    // Outcome 6.1: Approach the Floating Walmart
                    Console.WriteLine("You cautiously approach the floating Walmart.");
                    Console.WriteLine("It turns out that the floating Walmart is offering you a special discount!");
                    Console.WriteLine("You can buy any item from the Walmart store for half the price.");
                    Console.WriteLine("Will you buy something?");
                    Console.WriteLine("1 - Yes, buy something");
                    Console.WriteLine("2 - Trick them");

                    string buyChoice = Console.ReadLine();
                    if (buyChoice == "1")
                    {
                        // Outcome 6.1.1: Buy Something from Walmart
                        Console.WriteLine("You decide to take advantage of the discount and buy a Ramen Noodles Rocket Launcher!");
                        Console.WriteLine("This powerful weapon will aid you on your journey.");
                        Console.WriteLine("You gain +15 Attack Power and +10 Creativity.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (buyChoice == "2")
                    {
                        // Outcome 6.1.2: Decline Walmart's Offer
                        Console.WriteLine("You steal from walmart and so bill clinton got mad and teleported to you with his good pal goku");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Console.WriteLine("'You thought you could get away without paying eh?");
                        Console.ReadLine();
                        Console.WriteLine("little do you know that youll be the one paying'");
                        Console.ReadLine();
                        Console.WriteLine("Bill Clinton and goku then proceed to beat the shit out of you");
                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You stand there indecisively, and the floating Walmart drifts away.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (walmartChoice == "2")
                {
                    // Outcome 6.2: Ignore the Floating Walmart
                    Console.WriteLine("You decide to ignore the floating Walmart and continue your adventure.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                
                else
                {
                    Console.WriteLine("You stand there indecisively, and the floating Walmart slowly floats away BITCH.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
            }

            // Game Ending and Restart Option
            Console.WriteLine("Thank you for playing my shit-show!");
            Console.WriteLine("Would you like to play again? (yes/no)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() == "yes")
            {
                // Restart the game if the player wants to play again.
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye! Come back soon for more aids!");
                Console.ReadLine();
            }
        }
    }
}
