﻿using System;
using System.Threading.Tasks;
using QuizBot.BLL.Contracts;
using Telegram.Bot.Types;

namespace QuizBot.BLL.Core.Models.Commands
{
    public class ScoreCommand : Command
    {
        public override string Name { get => "/score"; set => throw new NotImplementedException(); }
        public override async Task<bool> ExecuteAsync(
            Message message,
            IBotService bot,
            IQuizService quizService)
        {
            await bot.SendMessage(message.Chat.Id, "Это викторина-бот");
            return true;
        }
    }
}