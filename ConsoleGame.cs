﻿using System;
            Console.WriteLine("Управляйте персонажем стрелками, соберите необходимое количество артефактов, чтобы сбежать от Зла\nОтбиться от Зла можно, если Ваша мощь больше");
            Console.ReadKey();
            Console.WriteLine("Прячась от стражи, вы оказываетесь в заброшенных готических катакомбах\nИз газет вы читали, что недавно здесь была поймана группа окультистов, проводившая свои тёмные обряды\nИсследуя помещения, вы заходите в большой старинный обветшалый зал\nНа стенах упоминается некое абстрактное зло, у которого нет имени\nНа одной из стен написано кровью:");
            Game.GenerateGameField(fieldsize, field);
            Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
            Console.BufferHeight = Console.LargestWindowHeight;
            Console.BufferWidth = Console.LargestWindowWidth;
            Game.GameFieldRender(fieldsize, field);